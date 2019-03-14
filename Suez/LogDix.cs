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
    public partial class LogDix : Form
    {
        string connectionstring;
        public LogDix()
        {
            InitializeComponent();
        }

        private void LogDix_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hwmdbDataSet.Log_Csv' table. You can move, or remove it, as needed.
           
            string Server = Properties.Settings.Default["Server"].ToString();
            string DB = Properties.Settings.Default["Database"].ToString();
            string UserN = Properties.Settings.Default["UserName"].ToString();
            string Password = Properties.Settings.Default["Password"].ToString();
            connectionstring = "Data Source=" + Server + ";MultipleActiveResultSets=true;Initial Catalog=" + DB + ";Persist Security Info=True;User ID=" + UserN + ";Password=" + Password + "";
            Dix();
        }

        private void Dix()
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            DataTable dt = new DataTable();
            string query = "select FileName,Date,CSV,Process from Log_Csv";
            SqlCommand cmd = new SqlCommand(query,conn);
            //SqlDataReader rdr = cmd.ExecuteReader();
            dt.Load(cmd.ExecuteReader());
            GridView.DataSource = dt;
            conn.Close();
        }
    }
}
