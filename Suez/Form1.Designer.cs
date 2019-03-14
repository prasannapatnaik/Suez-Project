namespace Suez
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fTPSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttn_start = new System.Windows.Forms.Button();
            this.bttn_stop = new System.Windows.Forms.Button();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.Bttn_DestFol = new System.Windows.Forms.Button();
            this.bttn_SourceFol = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_csv = new System.Windows.Forms.RadioButton();
            this.rd_txt = new System.Windows.Forms.RadioButton();
            this.lblerror = new System.Windows.Forms.Label();
            this.process = new System.Windows.Forms.Button();
            this.lbl_proc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.bttn_error = new System.Windows.Forms.Button();
            this.txt_errorpath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.fTPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.logToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // fTPToolStripMenuItem
            // 
            this.fTPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fTPSettingsToolStripMenuItem});
            this.fTPToolStripMenuItem.Enabled = false;
            this.fTPToolStripMenuItem.Name = "fTPToolStripMenuItem";
            this.fTPToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fTPToolStripMenuItem.Text = "FTP";
            // 
            // fTPSettingsToolStripMenuItem
            // 
            this.fTPSettingsToolStripMenuItem.Name = "fTPSettingsToolStripMenuItem";
            this.fTPSettingsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.fTPSettingsToolStripMenuItem.Text = "FTP Settings";
            this.fTPSettingsToolStripMenuItem.Click += new System.EventHandler(this.fTPSettingsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination";
            // 
            // bttn_start
            // 
            this.bttn_start.Location = new System.Drawing.Point(333, 140);
            this.bttn_start.Name = "bttn_start";
            this.bttn_start.Size = new System.Drawing.Size(75, 23);
            this.bttn_start.TabIndex = 3;
            this.bttn_start.Text = "Start";
            this.bttn_start.UseVisualStyleBackColor = true;
            this.bttn_start.Click += new System.EventHandler(this.bttn_start_Click);
            // 
            // bttn_stop
            // 
            this.bttn_stop.Location = new System.Drawing.Point(417, 140);
            this.bttn_stop.Name = "bttn_stop";
            this.bttn_stop.Size = new System.Drawing.Size(75, 23);
            this.bttn_stop.TabIndex = 4;
            this.bttn_stop.Text = "Pause";
            this.bttn_stop.UseVisualStyleBackColor = true;
            this.bttn_stop.Click += new System.EventHandler(this.bttn_stop_Click);
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(74, 73);
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(334, 20);
            this.txt_output.TabIndex = 5;
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(74, 39);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(334, 20);
            this.txt_input.TabIndex = 6;
            // 
            // Bttn_DestFol
            // 
            this.Bttn_DestFol.Location = new System.Drawing.Point(417, 71);
            this.Bttn_DestFol.Name = "Bttn_DestFol";
            this.Bttn_DestFol.Size = new System.Drawing.Size(75, 23);
            this.Bttn_DestFol.TabIndex = 8;
            this.Bttn_DestFol.Text = "Browse";
            this.Bttn_DestFol.UseVisualStyleBackColor = true;
            this.Bttn_DestFol.Click += new System.EventHandler(this.Bttn_DestFol_Click);
            // 
            // bttn_SourceFol
            // 
            this.bttn_SourceFol.Location = new System.Drawing.Point(417, 37);
            this.bttn_SourceFol.Name = "bttn_SourceFol";
            this.bttn_SourceFol.Size = new System.Drawing.Size(75, 23);
            this.bttn_SourceFol.TabIndex = 7;
            this.bttn_SourceFol.Text = "Browse";
            this.bttn_SourceFol.UseVisualStyleBackColor = true;
            this.bttn_SourceFol.Click += new System.EventHandler(this.bttn_SourceFol_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_csv);
            this.groupBox1.Controls.Add(this.rd_txt);
            this.groupBox1.Location = new System.Drawing.Point(15, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 34);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // rd_csv
            // 
            this.rd_csv.AutoSize = true;
            this.rd_csv.Checked = true;
            this.rd_csv.Location = new System.Drawing.Point(69, 11);
            this.rd_csv.Name = "rd_csv";
            this.rd_csv.Size = new System.Drawing.Size(42, 17);
            this.rd_csv.TabIndex = 11;
            this.rd_csv.TabStop = true;
            this.rd_csv.Text = "csv";
            this.rd_csv.UseVisualStyleBackColor = true;
            this.rd_csv.CheckedChanged += new System.EventHandler(this.rd_csv_CheckedChanged);
            // 
            // rd_txt
            // 
            this.rd_txt.AutoSize = true;
            this.rd_txt.Location = new System.Drawing.Point(6, 11);
            this.rd_txt.Name = "rd_txt";
            this.rd_txt.Size = new System.Drawing.Size(43, 17);
            this.rd_txt.TabIndex = 10;
            this.rd_txt.Text = "Txt ";
            this.rd_txt.UseVisualStyleBackColor = true;
            this.rd_txt.CheckedChanged += new System.EventHandler(this.rd_txt_CheckedChanged);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Location = new System.Drawing.Point(12, 168);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(50, 13);
            this.lblerror.TabIndex = 10;
            this.lblerror.Text = "Message";
            // 
            // process
            // 
            this.process.Location = new System.Drawing.Point(417, 168);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(75, 13);
            this.process.TabIndex = 11;
            this.process.Text = "button1";
            this.process.UseVisualStyleBackColor = true;
            this.process.Visible = false;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // lbl_proc
            // 
            this.lbl_proc.AutoSize = true;
            this.lbl_proc.Location = new System.Drawing.Point(330, 168);
            this.lbl_proc.Name = "lbl_proc";
            this.lbl_proc.Size = new System.Drawing.Size(0, 13);
            this.lbl_proc.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 23);
            this.panel1.TabIndex = 13;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(348, 4);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "info@envirosafetysolutions.in";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "HWM-Enviro Safety";
            // 
            // bttn_error
            // 
            this.bttn_error.Location = new System.Drawing.Point(417, 105);
            this.bttn_error.Name = "bttn_error";
            this.bttn_error.Size = new System.Drawing.Size(75, 23);
            this.bttn_error.TabIndex = 16;
            this.bttn_error.Text = "Browse";
            this.bttn_error.UseVisualStyleBackColor = true;
            this.bttn_error.Click += new System.EventHandler(this.bttn_error_Click);
            // 
            // txt_errorpath
            // 
            this.txt_errorpath.Location = new System.Drawing.Point(74, 107);
            this.txt_errorpath.Name = "txt_errorpath";
            this.txt_errorpath.Size = new System.Drawing.Size(334, 20);
            this.txt_errorpath.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Error Folder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 210);
            this.Controls.Add(this.bttn_error);
            this.Controls.Add(this.txt_errorpath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_proc);
            this.Controls.Add(this.process);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Bttn_DestFol);
            this.Controls.Add(this.bttn_SourceFol);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.bttn_stop);
            this.Controls.Add(this.bttn_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Toran CSV v1.0 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttn_start;
        private System.Windows.Forms.Button bttn_stop;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button Bttn_DestFol;
        private System.Windows.Forms.Button bttn_SourceFol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_csv;
        private System.Windows.Forms.RadioButton rd_txt;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.Label lbl_proc;
        private System.Windows.Forms.ToolStripMenuItem fTPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fTPSettingsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttn_error;
        private System.Windows.Forms.TextBox txt_errorpath;
        private System.Windows.Forms.Label label4;
    }
}

