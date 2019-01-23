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
        delegate void WriteReceivedCallback(string text);
        delegate void ChangeInputStateCallback(bool state);

        public TapChatServer()
        {
            InitializeComponent();
            server = new Server( this);
        }

        private void StartServer(object sender, EventArgs e)
        {
            string address = txtAddress.Text;
            string port = txtPort.Text;
            server.PortNumber = int.Parse(port);
            server.IpAdress = address;
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

        public void ReceiveMessage(string message)
        {
            if(txtReceived.InvokeRequired)
            {
                WriteReceivedCallback callbak = new WriteReceivedCallback(ReceiveMessage);
                Invoke(callbak, new object[] { message });
            }
            else
            {
                txtReceived.AppendText(message);
                txtReceived.AppendText(Environment.NewLine);
            }
        }

        private void StopServer(object sender, EventArgs e)
        {
            server.StopSession();
        }

        private void ClosingEvent(object sender, FormClosingEventArgs e)
        {
            if(server != null)
                server.StopSession();
        }

        public void ChangeInputState(bool state)
        {
            if (txtSend.InvokeRequired)
            {
                ChangeInputStateCallback callback = new ChangeInputStateCallback(ChangeInputState);
                Invoke(callback, new object[] { state });
            }
            else
            {
                txtSend.Text = "";
                txtSend.ReadOnly = state;
            }
        }

        private void sendMessage(object sender, EventArgs e)
        {
            server.SendMessage(txtSend.Text);
        }

        private void SetParameters(object sender, EventArgs e)
        {
            try
            {
                int ici = int.Parse(txtICI.Text);
                int iwi = int.Parse(txtIWI.Text);
                server.ICI = ici;
                server.IWI = iwi;
            }
            catch(Exception ex)
            {
                LogMessage("Invalid ICI and/or IWI values");
            }
        }
    }
}
