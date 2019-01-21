using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace TapChat
{
    public class Server
    {
        //TCP listener
        TcpListener listener;

        //Ip address
        public string IpAdress { get; set; }

        //Port number
        public int PortNumber { get; set; }

        //Text box log
        TapChatServer ChatApp { get; set; }

        //Array of communication threads
        List<CommunicationSession> communicationThreads;

        //Loop control flag
        private bool stopLoop = false;

        //Constructor
        public Server(string ipAddress, int portNumber, TapChatServer chatServerApp)
        {
            IpAdress = ipAddress;
            PortNumber = portNumber;
            ChatApp = chatServerApp;
            communicationThreads = new List<CommunicationSession>();
      
        }

        //Start listening
        public void StartListening()
        {
            stopLoop = false;
            Thread listenThread = new Thread(new ThreadStart(ListenConnections));
            listenThread.Start();
        }

        //Infinite listening loop
        void ListenConnections()
        {
            
            if (IpAdress.Equals("localhost"))
            {
                listener = new TcpListener(IPAddress.Any, PortNumber);
            }
            else
            {
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = null;
                foreach (IPAddress addr in ipHostInfo.AddressList)
                    if (addr.ToString().Equals(IpAdress))
                        ipAddress = addr;
                if (ipAddress == null)
                {
                    ChatApp.LogMessage("Unable to listen in the specified address");
                    return;
                }
                else
                {
                    listener = new TcpListener(ipAddress, PortNumber);
                }
            }
                
            listener.Start();
            TcpClient client1 = null;
            TcpClient client2 = null;
            ChatApp.LogMessage("Listening to connections...");
            while (!stopLoop)
            {
                try
                {
                    TcpClient newClient = listener.AcceptTcpClient();
                    if (client1 == null)
                    {
                        client1 = newClient;
                        ChatApp.LogMessage("First client received");
                    }
                    else if (client2 == null)
                    {
                        client2 = newClient;
                        ChatApp.LogMessage("Second client received");
                        CommunicationSession session = new CommunicationSession(client1, client2, ChatApp);
                        session.StartSession();
                        communicationThreads.Add(session);
                        client1 = null;
                        client2 = null;
                    }
                }
                catch(Exception)
                {
                    break;
                }
            }

        }

        //Stop all sessions
        public void StopSessions()
        {
            foreach (CommunicationSession session in communicationThreads)
                session.Stop = true;
            stopLoop = true;
            if(listener != null)
                listener.Stop();
            ChatApp.LogMessage("Server Stopped");
        }

        

        //Communication sessions
        internal class CommunicationSession
        {

            //Get a message command
            public static string SAY = "SAY";

            //Stop command
            public static string STOP = "STOP";

            //Comm thread
            Thread commThread;

            //Stop flag
            public bool Stop { get; set; }

            //TCP clients
            TcpClient client1;
            TcpClient client2;

            //Chat app
            TapChatServer app;

            //Constructor
            public CommunicationSession(TcpClient user1, TcpClient user2, TapChatServer application)
            {
                client1 = user1;
                client2 = user2;
                app = application;
                Stop = false;
            }

            //Start session
            public void StartSession()
            {
                commThread = new Thread(new ThreadStart(Protocol));
                commThread.Start();
            }

            //Session protocol
            void Protocol()
            {

                int clientTurn = 1;
                app.LogMessage("Protocol Starting");
                WriteMessageToClient(client1, SAY);
                while (!Stop)
                {
                    if (clientTurn == 1)
                    {
                        string msg = GetMessageFromClient(client1);
                        WriteMessageToClient(client2, msg);
                        clientTurn = 2;
                    }
                    else
                    {
                        string msg = GetMessageFromClient(client2);
                        WriteMessageToClient(client1, msg);
                        clientTurn = 1;
                    }
                }

                client1.Close();
                client2.Close();
                app.LogMessage("Session closed");

            }

            //Get a string from a TcpClient 
            string GetMessageFromClient(TcpClient client)
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];
                int bytesRead = stream.Read(buffer, 0, client.ReceiveBufferSize);
                string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                return data;
            }

            //Write a string to a TcpClient
            void WriteMessageToClient(TcpClient client, string message)
            {
                NetworkStream stream = client.GetStream();
                byte[] bytesToSend = Encoding.ASCII.GetBytes(message);
                stream.Write(bytesToSend, 0, bytesToSend.Length);
            }

        }
    }
}
