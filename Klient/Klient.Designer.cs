using System;

namespace Klient
{
    partial class Klient
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
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMedd = new System.Windows.Forms.TextBox();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Namn = new System.Windows.Forms.Label();
            this.tbxNmn = new System.Windows.Forms.TextBox();
            this.btnAnslut = new System.Windows.Forms.Button();
            this.tbxLogg = new System.Windows.Forms.RichTextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(277, 12);
            this.tbxIP.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(208, 22);
            this.tbxIP.TabIndex = 0;
            this.tbxIP.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 378);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Meddelande";
            // 
            // tbxMedd
            // 
            this.tbxMedd.Location = new System.Drawing.Point(14, 399);
            this.tbxMedd.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMedd.Multiline = true;
            this.tbxMedd.Name = "tbxMedd";
            this.tbxMedd.Size = new System.Drawing.Size(284, 128);
            this.tbxMedd.TabIndex = 4;
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(277, 58);
            this.tbxPort.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(208, 22);
            this.tbxPort.TabIndex = 0;
            this.tbxPort.Text = "5555";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(306, 399);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(87, 129);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Skicka";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Logg";
            // 
            // Namn
            // 
            this.Namn.AutoSize = true;
            this.Namn.Location = new System.Drawing.Point(166, 108);
            this.Namn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Namn.Name = "Namn";
            this.Namn.Size = new System.Drawing.Size(45, 17);
            this.Namn.TabIndex = 9;
            this.Namn.Text = "Namn";
            // 
            // tbxNmn
            // 
            this.tbxNmn.Location = new System.Drawing.Point(277, 105);
            this.tbxNmn.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNmn.Name = "tbxNmn";
            this.tbxNmn.Size = new System.Drawing.Size(208, 22);
            this.tbxNmn.TabIndex = 0;
            // 
            // btnAnslut
            // 
            this.btnAnslut.Location = new System.Drawing.Point(496, 102);
            this.btnAnslut.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnslut.Name = "btnAnslut";
            this.btnAnslut.Size = new System.Drawing.Size(99, 28);
            this.btnAnslut.TabIndex = 10;
            this.btnAnslut.Text = "Anslut";
            this.btnAnslut.UseVisualStyleBackColor = true;
            this.btnAnslut.Click += new System.EventHandler(this.btnAnslut_Click);
            // 
            // tbxLogg
            // 
            this.tbxLogg.Location = new System.Drawing.Point(14, 165);
            this.tbxLogg.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLogg.Name = "tbxLogg";
            this.tbxLogg.ReadOnly = true;
            this.tbxLogg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbxLogg.Size = new System.Drawing.Size(380, 209);
            this.tbxLogg.TabIndex = 11;
            this.tbxLogg.Text = "";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(496, 12);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(99, 73);
            this.btn_Refresh.TabIndex = 12;
            this.btn_Refresh.Text = "⟳";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbo
            // 
            this.lbo.FormattingEnabled = true;
            this.lbo.ItemHeight = 16;
            this.lbo.Location = new System.Drawing.Point(401, 170);
            this.lbo.Name = "lbo";
            this.lbo.Size = new System.Drawing.Size(195, 356);
            this.lbo.TabIndex = 13;
            // 
            // Klient
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 538);
            this.Controls.Add(this.lbo);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.tbxLogg);
            this.Controls.Add(this.btnAnslut);
            this.Controls.Add(this.Namn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbxMedd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNmn);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.tbxIP);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Klient";
            this.Text = "Klient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Klient_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMedd;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Namn;
        private System.Windows.Forms.TextBox tbxNmn;
        private System.Windows.Forms.Button btnAnslut;
        private System.Windows.Forms.RichTextBox tbxLogg;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ListBox lbo;
    }
}

