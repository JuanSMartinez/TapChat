﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Client
{
    public class Client
    {

        //Ip address
        public string IpAddress { get; set; }

        //Port number
        public int PortNumber { get; set; }

        //TapChat client application
        TapChatClient Application { get; set; }

        //TCP client
        TcpClient client;

        //Message buffer
        string msgBuffer;

        //Lock object
        private static object lockObj = new object();

        //Stop flag
        private bool stop = false;

        //Constructor
        public Client(string ipAddress, int portNumber, TapChatClient chatApplication)
        {
            IpAddress = ipAddress;
            PortNumber = portNumber;
            Application = chatApplication;
            msgBuffer = "";
        }

        //Start protocol
        public void StartProtocol()
        {
            Thread protocolThread = new Thread(new ThreadStart(ProtocolThread));
            protocolThread.Start();
        }

        //Send a message
        public void SendMessage(string msg)
        {
            lock (lockObj)
            {
                msgBuffer = msg;
            }
        }

        void ProtocolThread()
        {
            client = new TcpClient(IpAddress, PortNumber);
            if (client.Connected)
            {
                Application.LogMessage("CONNECTED TO SERVER");
                string msg = GetMessage();
                while (!stop)
                {
                    Application.ChangeInputState(false);
                    Application.LogMessage(msg);
                    while (msgBuffer.Equals("")) ;
                    
                    WriteMessage(msgBuffer);
                    msgBuffer = "";
                    Application.ChangeInputState(true);
                    msg = GetMessage();
                }

            }
            
            
        }

        //Get a string  
        string GetMessage()
        {
            try
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];
                int bytesRead = stream.Read(buffer, 0, client.ReceiveBufferSize);
                string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                return data;
            }
            catch(Exception e)
            {
                stop = true;
                return "";
            }
        }

        //Write a string 
        void WriteMessage(string message)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                byte[] bytesToSend = Encoding.ASCII.GetBytes(message);
                stream.Write(bytesToSend, 0, bytesToSend.Length);
            }
            catch(Exception e)
            {
                stop = true;
        
            }
        }
    }
}