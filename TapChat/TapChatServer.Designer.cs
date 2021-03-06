﻿namespace TapChat
{
    partial class TapChatServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.labelPortNumber = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.butStop = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.butSend = new System.Windows.Forms.Button();
            this.labelSend = new System.Windows.Forms.Label();
            this.labelReceived = new System.Windows.Forms.Label();
            this.txtICI = new System.Windows.Forms.TextBox();
            this.txtIWI = new System.Windows.Forms.TextBox();
            this.labelICI = new System.Windows.Forms.Label();
            this.labelIWI = new System.Windows.Forms.Label();
            this.butSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(31, 52);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(61, 13);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "IP Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(34, 68);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.Text = "localhost";
            // 
            // labelPortNumber
            // 
            this.labelPortNumber.AutoSize = true;
            this.labelPortNumber.Location = new System.Drawing.Point(185, 52);
            this.labelPortNumber.Name = "labelPortNumber";
            this.labelPortNumber.Size = new System.Drawing.Size(69, 13);
            this.labelPortNumber.TabIndex = 2;
            this.labelPortNumber.Text = "Port Number:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(188, 68);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "8888";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(34, 117);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Start Server";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.StartServer);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(34, 200);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(254, 139);
            this.txtLog.TabIndex = 5;
            // 
            // butStop
            // 
            this.butStop.Location = new System.Drawing.Point(188, 117);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(75, 23);
            this.butStop.TabIndex = 6;
            this.butStop.Text = "Stop Sever";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.StopServer);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(365, 49);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.ReadOnly = true;
            this.txtSend.Size = new System.Drawing.Size(215, 117);
            this.txtSend.TabIndex = 7;
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(365, 200);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.ReadOnly = true;
            this.txtReceived.Size = new System.Drawing.Size(215, 139);
            this.txtReceived.TabIndex = 8;
            // 
            // butSend
            // 
            this.butSend.Location = new System.Drawing.Point(612, 143);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(75, 23);
            this.butSend.TabIndex = 9;
            this.butSend.Text = "Send";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.sendMessage);
            // 
            // labelSend
            // 
            this.labelSend.AutoSize = true;
            this.labelSend.Location = new System.Drawing.Point(362, 33);
            this.labelSend.Name = "labelSend";
            this.labelSend.Size = new System.Drawing.Size(35, 13);
            this.labelSend.TabIndex = 10;
            this.labelSend.Text = "Send:";
            // 
            // labelReceived
            // 
            this.labelReceived.AutoSize = true;
            this.labelReceived.Location = new System.Drawing.Point(362, 184);
            this.labelReceived.Name = "labelReceived";
            this.labelReceived.Size = new System.Drawing.Size(56, 13);
            this.labelReceived.TabIndex = 11;
            this.labelReceived.Text = "Received:";
            // 
            // txtICI
            // 
            this.txtICI.Location = new System.Drawing.Point(34, 369);
            this.txtICI.Name = "txtICI";
            this.txtICI.Size = new System.Drawing.Size(75, 20);
            this.txtICI.TabIndex = 12;
            // 
            // txtIWI
            // 
            this.txtIWI.Location = new System.Drawing.Point(129, 369);
            this.txtIWI.Name = "txtIWI";
            this.txtIWI.Size = new System.Drawing.Size(75, 20);
            this.txtIWI.TabIndex = 13;
            // 
            // labelICI
            // 
            this.labelICI.AutoSize = true;
            this.labelICI.Location = new System.Drawing.Point(31, 353);
            this.labelICI.Name = "labelICI";
            this.labelICI.Size = new System.Drawing.Size(23, 13);
            this.labelICI.TabIndex = 14;
            this.labelICI.Text = "ICI:";
            // 
            // labelIWI
            // 
            this.labelIWI.AutoSize = true;
            this.labelIWI.Location = new System.Drawing.Point(126, 353);
            this.labelIWI.Name = "labelIWI";
            this.labelIWI.Size = new System.Drawing.Size(27, 13);
            this.labelIWI.TabIndex = 15;
            this.labelIWI.Text = "IWI:";
            // 
            // butSet
            // 
            this.butSet.Location = new System.Drawing.Point(220, 367);
            this.butSet.Name = "butSet";
            this.butSet.Size = new System.Drawing.Size(68, 23);
            this.butSet.TabIndex = 16;
            this.butSet.Text = "Set";
            this.butSet.UseVisualStyleBackColor = true;
            this.butSet.Click += new System.EventHandler(this.SetParameters);
            // 
            // TapChatServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butSet);
            this.Controls.Add(this.labelIWI);
            this.Controls.Add(this.labelICI);
            this.Controls.Add(this.txtIWI);
            this.Controls.Add(this.txtICI);
            this.Controls.Add(this.labelReceived);
            this.Controls.Add(this.labelSend);
            this.Controls.Add(this.butSend);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.labelPortNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.labelAddress);
            this.Name = "TapChatServer";
            this.Text = "TapChat Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label labelPortNumber;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.Label labelSend;
        private System.Windows.Forms.Label labelReceived;
        private System.Windows.Forms.TextBox txtICI;
        private System.Windows.Forms.TextBox txtIWI;
        private System.Windows.Forms.Label labelICI;
        private System.Windows.Forms.Label labelIWI;
        private System.Windows.Forms.Button butSet;
    }
}

