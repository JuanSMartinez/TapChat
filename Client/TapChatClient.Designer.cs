namespace Client
{
    partial class TapChatClient
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butSend = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtICI = new System.Windows.Forms.TextBox();
            this.txtIWI = new System.Windows.Forms.TextBox();
            this.butSet = new System.Windows.Forms.Button();
            this.labelICI = new System.Windows.Forms.Label();
            this.labelIWI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(161, 65);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.Text = "localhost";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(273, 64);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "8888";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(161, 46);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address:";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(270, 46);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(69, 13);
            this.labelPort.TabIndex = 3;
            this.labelPort.Text = "Port Number:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(161, 163);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(241, 97);
            this.txtMessage.TabIndex = 4;
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(161, 312);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.Size = new System.Drawing.Size(241, 86);
            this.txtResponse.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Send:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Received:";
            // 
            // butSend
            // 
            this.butSend.Location = new System.Drawing.Point(428, 163);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(75, 23);
            this.butSend.TabIndex = 8;
            this.butSend.Text = "Send";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.sendMessage);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(379, 62);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.connectToServer);
            // 
            // txtICI
            // 
            this.txtICI.Location = new System.Drawing.Point(161, 111);
            this.txtICI.Name = "txtICI";
            this.txtICI.Size = new System.Drawing.Size(100, 20);
            this.txtICI.TabIndex = 10;
            // 
            // txtIWI
            // 
            this.txtIWI.Location = new System.Drawing.Point(273, 111);
            this.txtIWI.Name = "txtIWI";
            this.txtIWI.Size = new System.Drawing.Size(100, 20);
            this.txtIWI.TabIndex = 11;
            // 
            // butSet
            // 
            this.butSet.Location = new System.Drawing.Point(379, 108);
            this.butSet.Name = "butSet";
            this.butSet.Size = new System.Drawing.Size(75, 23);
            this.butSet.TabIndex = 12;
            this.butSet.Text = "Set";
            this.butSet.UseVisualStyleBackColor = true;
            this.butSet.Click += new System.EventHandler(this.SetParameters);
            // 
            // labelICI
            // 
            this.labelICI.AutoSize = true;
            this.labelICI.Location = new System.Drawing.Point(161, 95);
            this.labelICI.Name = "labelICI";
            this.labelICI.Size = new System.Drawing.Size(23, 13);
            this.labelICI.TabIndex = 13;
            this.labelICI.Text = "ICI:";
            // 
            // labelIWI
            // 
            this.labelIWI.AutoSize = true;
            this.labelIWI.Location = new System.Drawing.Point(270, 95);
            this.labelIWI.Name = "labelIWI";
            this.labelIWI.Size = new System.Drawing.Size(27, 13);
            this.labelIWI.TabIndex = 14;
            this.labelIWI.Text = "IWI:";
            // 
            // TapChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelIWI);
            this.Controls.Add(this.labelICI);
            this.Controls.Add(this.butSet);
            this.Controls.Add(this.txtIWI);
            this.Controls.Add(this.txtICI);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.butSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtAddress);
            this.Name = "TapChatClient";
            this.Text = "TapChat Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingClient);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtICI;
        private System.Windows.Forms.TextBox txtIWI;
        private System.Windows.Forms.Button butSet;
        private System.Windows.Forms.Label labelICI;
        private System.Windows.Forms.Label labelIWI;
    }
}

