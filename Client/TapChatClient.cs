using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class TapChatClient : Form
    {
        Client client;
        delegate void SetMessageCallback(string text);
        delegate void ChangeInputStateCallback(bool state);

        public TapChatClient()
        {
            InitializeComponent();
        }

        private void connectToServer(object sender, EventArgs e)
        {
            client = new Client(txtAddress.Text, int.Parse(txtPort.Text), this);
            client.StartProtocol();
        }

        private void sendMessage(object sender, EventArgs e)
        {
            client.SendMessage(txtMessage.Text);
        }

        public void ChangeInputState(bool state)
        {
            if (txtMessage.InvokeRequired)
            {
                ChangeInputStateCallback callback = new ChangeInputStateCallback(ChangeInputState);
                Invoke(callback, new object[] { state });
            }
            else
            {
                txtMessage.Text = "";
                txtMessage.ReadOnly = state;
            }
        }

        public void LogMessage(string msg)
        {
            if (txtResponse.InvokeRequired)
            {
                SetMessageCallback callback = new SetMessageCallback(LogMessage);
                Invoke(callback, new object[] { msg });
            }
            else
            {
                txtResponse.AppendText(msg);
                txtResponse.AppendText(Environment.NewLine);
            }
        }

    }
}
