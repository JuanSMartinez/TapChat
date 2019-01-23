using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using Taps;

namespace TapChat
{
    public class Server
    {

        //Get a message command
        public static string SAY = "SAY";

        //Stop command
        public static string STOP = "STOP";

        //TCP listener
        TcpListener listener;

        //Ip address
        public string IpAdress { get; set; }

        //Port number
        public int PortNumber { get; set; }

        //Text box log
        TapChatServer ChatApp { get; set; }

        //Listener thread
        Thread listenThread;

        //Stop flag
        bool stop = false;

        //Message buffer
        string msgBuffer = "";

        //ICI
        public int ICI { get; set; }

        //IWI
        public int IWI { get; set; }

        //Lock object
        private static object lockObj = new object();

        //Constructor
        public Server(string ipAddress, int portNumber, TapChatServer chatServerApp)
        {
            IpAdress = ipAddress;
            PortNumber = portNumber;
            ChatApp = chatServerApp;
            Motu instance = Motu.Instance;
            ICI = 150;
            IWI = 500;
        }

        public Server(TapChatServer chatServerApp)
        {
            ChatApp = chatServerApp;
            Motu instance = Motu.Instance;
            ICI = 150;
            IWI = 500;
        }

        //Start listening
        public void StartListening()
        {

            listenThread = new Thread(new ThreadStart(ListenConnections));
            listenThread.Start();
        }

        //Send a message
        public void SendMessage(string msg)
        {
            lock (lockObj)
            {
                msgBuffer = msg;
            }
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
            ChatApp.LogMessage("Listening to connections...");
            
            try
            {
                TcpClient client = listener.AcceptTcpClient();
                ChatApp.LogMessage("Client received");
                StartProtocol(client);
                
            }
            catch (Exception)
            {
                return;
            }

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

        //Start Protocol
        private void StartProtocol(TcpClient client)
        {
            ChatApp.LogMessage("Protocol Starting");
            WriteMessageToClient(client, SAY);
            while (!stop)
            {
                ChatApp.ChangeInputState(true);
                string msg = GetMessageFromClient(client);
                ChatApp.ReceiveMessage(msg);
                if (!msg.Equals("SAY") && Motu.Instance.IsInitialized())
                    Motu.Instance.PlaySentence(msg, ICI, IWI);
                else
                    ChatApp.ReceiveMessage("MOTU not initialized yet");
                ChatApp.ChangeInputState(false);
                while (msgBuffer.Equals("")) ;
                WriteMessageToClient(client, msgBuffer);
                lock (lockObj)
                {
                    msgBuffer = "";
                }
            }
        }

        //Stop all sessions
        public void StopSession()
        {
            stop = true;
            if(listener != null)
                listener.Stop();
            if(listenThread != null)
            {
                listenThread.Abort();
                listenThread = null;
            }
            
            ChatApp.LogMessage("Server Stopped");
        }

        
    }
}
