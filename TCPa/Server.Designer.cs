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
            this.SuspendLayout();
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(48, 20);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(125, 20);
            this.tbxPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Logg";
            // 
            // tbxLogg
            // 
            this.tbxLogg.Location = new System.Drawing.Point(16, 85);
            this.tbxLogg.Name = "tbxLogg";
            this.tbxLogg.ReadOnly = true;
            this.tbxLogg.Size = new System.Drawing.Size(256, 305);
            this.tbxLogg.TabIndex = 3;
            this.tbxLogg.Text = "";
            // 
            // btnTaEmot
            // 
            this.btnTaEmot.Location = new System.Drawing.Point(197, 18);
            this.btnTaEmot.Name = "btnTaEmot";
            this.btnTaEmot.Size = new System.Drawing.Size(75, 23);
            this.btnTaEmot.TabIndex = 4;
            this.btnTaEmot.Text = "Ta emot";
            this.btnTaEmot.UseVisualStyleBackColor = true;
            this.btnTaEmot.Click += new System.EventHandler(this.btnTaEmot_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 406);
            this.Controls.Add(this.btnTaEmot);
            this.Controls.Add(this.tbxLogg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPort);
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
    }
}

