namespace TCPa
{
    partial class Server
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
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxLogg = new System.Windows.Forms.RichTextBox();
            this.btnTaEmot = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(64, 25);
            this.tbxPort.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(165, 22);
            this.tbxPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Logg";
            // 
            // tbxLogg
            // 
            this.tbxLogg.Location = new System.Drawing.Point(21, 105);
            this.tbxLogg.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLogg.Name = "tbxLogg";
            this.tbxLogg.ReadOnly = true;
            this.tbxLogg.Size = new System.Drawing.Size(340, 222);
            this.tbxLogg.TabIndex = 3;
            this.tbxLogg.Text = "";
            // 
            // btnTaEmot
            // 
            this.btnTaEmot.Location = new System.Drawing.Point(263, 22);
            this.btnTaEmot.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaEmot.Name = "btnTaEmot";
            this.btnTaEmot.Size = new System.Drawing.Size(100, 28);
            this.btnTaEmot.TabIndex = 4;
            this.btnTaEmot.Text = "Ta emot";
            this.btnTaEmot.UseVisualStyleBackColor = true;
            this.btnTaEmot.Click += new System.EventHandler(this.btnTaEmot_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.SystemColors.Control;
            this.lblA.Location = new System.Drawing.Point(72, 337);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(12, 17);
            this.lblA.TabIndex = 5;
            this.lblA.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 337);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Online:";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 500);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnTaEmot);
            this.Controls.Add(this.tbxLogg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPort);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbxLogg;
        private System.Windows.Forms.Button btnTaEmot;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label label3;
    }
}

