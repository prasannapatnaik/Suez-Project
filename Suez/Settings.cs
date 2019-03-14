using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suez
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void bttn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source='" + txt_server.Text + "';MultipleActiveResultSets=true;Initial Catalog='" + txt_db.Text + "';User ID='" + txt_username.Text + "';Password='" + txt_password.Text + "'"))
                {
                    try
                    {
                        connection.Open();
                        if (connection.State == ConnectionState.Open) // if connection.Open was successful
                        {

                            Properties.Settings.Default["Server"] = txt_server.Text;
                            Properties.Settings.Default["Database"] = txt_db.Text;
                            Properties.Settings.Default["UserName"] = txt_username.Text;
                            Properties.Settings.Default["Password"] = txt_password.Text;
                            
                            Properties.Settings.Default.Save();
                            lblmsg.Text = "Connected successfully";
                            lblmsg.ForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            lblmsg.Text = "Connection Unsuccessful";
                            lblmsg.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    catch (SqlException ex)
                    {
                        lblmsg.Text = ex.Message;
                        lblmsg.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Connectivity");
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txt_server.Text = Properties.Settings.Default["Server"].ToString();
            txt_db.Text = Properties.Settings.Default["Database"].ToString();
            txt_username.Text = Properties.Settings.Default["UserName"].ToString();
            txt_password.Text = Properties.Settings.Default["Password"].ToString();
            if (Properties.Settings.Default["Check"].ToString() == "ASC") { sort_ASC.Checked = true; } else { sort_DEC.Checked = true; }
            if (Properties.Settings.Default["CSV"].ToString() == "SINGLE") { rd_singlefile.Checked = true; } else { rd_multfile.Checked = true; }
        }

        private void sort_ASC_CheckedChanged(object sender, EventArgs e)
        {
            if (sort_ASC.Checked == true) 
            {
                Form1.check = "ASC";
                Properties.Settings.Default["Check"] = "ASC"; 
                Properties.Settings.Default.Save(); 
            }
        }

        private void sort_DEC_CheckedChanged(object sender, EventArgs e)
        {
            if (sort_DEC.Checked == true)
            {
                Form1.check = "DESC";
                Properties.Settings.Default["Check"] = "DESC";
                Properties.Settings.Default.Save();
            }
        }

        private void rd_singlefile_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_singlefile.Checked == true)
            {
                Form1.CSVFile = "SINGLE";
                Properties.Settings.Default["CSV"] = "SINGLE";
                Properties.Settings.Default.Save();
            }
        }

        private void rd_multfile_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_multfile.Checked == true)
            {
                Form1.CSVFile = "MULT";
                Properties.Settings.Default["CSV"] = "MULT";
                Properties.Settings.Default.Save();
            }
        }
    }
}
