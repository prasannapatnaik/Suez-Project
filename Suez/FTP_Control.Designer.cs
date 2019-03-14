namespace Suez
{
    partial class FTP_Control
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_UN = new System.Windows.Forms.TextBox();
            this.bttn_Connect = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(92, 30);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(162, 20);
            this.txt_IP.TabIndex = 3;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(92, 102);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(162, 20);
            this.txt_Pass.TabIndex = 4;
            // 
            // txt_UN
            // 
            this.txt_UN.Location = new System.Drawing.Point(92, 65);
            this.txt_UN.Name = "txt_UN";
            this.txt_UN.Size = new System.Drawing.Size(162, 20);
            this.txt_UN.TabIndex = 5;
            // 
            // bttn_Connect
            // 
            this.bttn_Connect.Location = new System.Drawing.Point(179, 137);
            this.bttn_Connect.Name = "bttn_Connect";
            this.bttn_Connect.Size = new System.Drawing.Size(75, 23);
            this.bttn_Connect.TabIndex = 6;
            this.bttn_Connect.Text = "Link";
            this.bttn_Connect.UseVisualStyleBackColor = true;
            this.bttn_Connect.Click += new System.EventHandler(this.bttn_Connect_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(21, 227);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(37, 13);
            this.lblmsg.TabIndex = 7;
            this.lblmsg.Text = "Status";
            // 
            // FTP_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.bttn_Connect);
            this.Controls.Add(this.txt_UN);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FTP_Control";
            this.Text = "FTP_Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_UN;
        private System.Windows.Forms.Button bttn_Connect;
        private System.Windows.Forms.Label lblmsg;
    }
}