using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TapChat
{
    public partial class TapChatServer : Form
    {
        Server server;
        delegate void SetLogCallback(string text);

        public TapChatServer()
        {
            InitializeComponent();
        }

        private void StartServer(object sender, EventArgs e)
        {
            string address = txtAddress.Text;
            string port = txtPort.Text;
            server = new Server(address, int.Parse(port), this);
            server.StartListening();
        }

        public void LogMessage(string msg)
        {
            if (txtLog.InvokeRequired)
            {
                SetLogCallback callback = new SetLogCallback(LogMessage);
                Invoke(callback, new object[] { msg });
            }
            else
            {
                txtLog.AppendText(msg);
                txtLog.AppendText(Environment.NewLine);

            }
        }

        private void StopServer(object sender, EventArgs e)
        {
            server.StopSessions();
        }

        private void ClosingEvent(object sender, FormClosingEventArgs e)
        {
            if(server != null)
                server.StopSessions();
        }
    }
}
