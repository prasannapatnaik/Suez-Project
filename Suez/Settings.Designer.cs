namespace Suez
{
    partial class Settings
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
            this.label4 = new System.Windows.Forms.Label();
            this.bttn_Connect = new System.Windows.Forms.Button();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.txt_db = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sort_DEC = new System.Windows.Forms.RadioButton();
            this.sort_ASC = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_singlefile = new System.Windows.Forms.RadioButton();
            this.rd_multfile = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // bttn_Connect
            // 
            this.bttn_Connect.Location = new System.Drawing.Point(184, 160);
            this.bttn_Connect.Name = "bttn_Connect";
            this.bttn_Connect.Size = new System.Drawing.Size(75, 23);
            this.bttn_Connect.TabIndex = 4;
            this.bttn_Connect.Text = "Connect";
            this.bttn_Connect.UseVisualStyleBackColor = true;
            this.bttn_Connect.Click += new System.EventHandler(this.bttn_Connect_Click);
            // 
            // txt_server
            // 
            this.txt_server.Location = new System.Drawing.Point(80, 11);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(179, 20);
            this.txt_server.TabIndex = 5;
            // 
            // txt_db
            // 
            this.txt_db.Location = new System.Drawing.Point(80, 42);
            this.txt_db.Name = "txt_db";
            this.txt_db.Size = new System.Drawing.Size(179, 20);
            this.txt_db.TabIndex = 6;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(80, 72);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(179, 20);
            this.txt_username.TabIndex = 7;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(80, 108);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(179, 20);
            this.txt_password.TabIndex = 8;
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(23, 140);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 13);
            this.lblmsg.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sort_DEC);
            this.groupBox1.Controls.Add(this.sort_ASC);
            this.groupBox1.Location = new System.Drawing.Point(12, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 38);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort";
            // 
            // sort_DEC
            // 
            this.sort_DEC.AutoSize = true;
            this.sort_DEC.Checked = true;
            this.sort_DEC.Location = new System.Drawing.Point(156, 16);
            this.sort_DEC.Name = "sort_DEC";
            this.sort_DEC.Size = new System.Drawing.Size(47, 17);
            this.sort_DEC.TabIndex = 1;
            this.sort_DEC.TabStop = true;
            this.sort_DEC.Text = "DEC";
            this.sort_DEC.UseVisualStyleBackColor = true;
            this.sort_DEC.CheckedChanged += new System.EventHandler(this.sort_DEC_CheckedChanged);
            // 
            // sort_ASC
            // 
            this.sort_ASC.AutoSize = true;
            this.sort_ASC.Location = new System.Drawing.Point(14, 16);
            this.sort_ASC.Name = "sort_ASC";
            this.sort_ASC.Size = new System.Drawing.Size(46, 17);
            this.sort_ASC.TabIndex = 0;
            this.sort_ASC.TabStop = true;
            this.sort_ASC.Text = "ASC";
            this.sort_ASC.UseVisualStyleBackColor = true;
            this.sort_ASC.CheckedChanged += new System.EventHandler(this.sort_ASC_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rd_singlefile);
            this.groupBox2.Controls.Add(this.rd_multfile);
            this.groupBox2.Location = new System.Drawing.Point(12, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 38);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CSV File";
            // 
            // rd_singlefile
            // 
            this.rd_singlefile.AutoSize = true;
            this.rd_singlefile.Checked = true;
            this.rd_singlefile.Location = new System.Drawing.Point(156, 16);
            this.rd_singlefile.Name = "rd_singlefile";
            this.rd_singlefile.Size = new System.Drawing.Size(73, 17);
            this.rd_singlefile.TabIndex = 1;
            this.rd_singlefile.TabStop = true;
            this.rd_singlefile.Text = "Single File";
            this.rd_singlefile.UseVisualStyleBackColor = true;
            this.rd_singlefile.CheckedChanged += new System.EventHandler(this.rd_singlefile_CheckedChanged);
            // 
            // rd_multfile
            // 
            this.rd_multfile.AutoSize = true;
            this.rd_multfile.Location = new System.Drawing.Point(14, 16);
            this.rd_multfile.Name = "rd_multfile";
            this.rd_multfile.Size = new System.Drawing.Size(80, 17);
            this.rd_multfile.TabIndex = 0;
            this.rd_multfile.TabStop = true;
            this.rd_multfile.Text = "Multiple File";
            this.rd_multfile.UseVisualStyleBackColor = true;
            this.rd_multfile.CheckedChanged += new System.EventHandler(this.rd_multfile_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Location = new System.Drawing.Point(12, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 38);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totalizer";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(156, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "NO";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Display (YES)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 350);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_db);
            this.Controls.Add(this.txt_server);
            this.Controls.Add(this.bttn_Connect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttn_Connect;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.TextBox txt_db;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sort_DEC;
        private System.Windows.Forms.RadioButton sort_ASC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd_singlefile;
        private System.Windows.Forms.RadioButton rd_multfile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}