using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suez
{
    public partial class Form1 : Form
    {
        //string connectionstring = @"Data Source=DESKTOP-203834V\SQLEXPRESS;Initial Catalog=hwmdb;Persist Security Info=True;User ID=sa;Password=Enviro@123";
        Timer timer1;
        string siteID, LogSN, connectionstring, strFilePath , proc= "";
        int i = 0;
        string[] allfiles;
        SqlConnection conn = new SqlConnection();
        StreamWriter sw;
        public static string check,CSVFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void bttn_SourceFol_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                txt_input.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
                Properties.Settings.Default["Input"] = txt_input.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void Bttn_DestFol_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                txt_output.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
                Properties.Settings.Default["Output"] = txt_output.Text;
                Properties.Settings.Default.Save();
            }

        }

        private void bttn_start_Click(object sender, EventArgs e)
        {
            InitTimer();
            bttn_start.Enabled = false;
            
        }

        private void Readfile(string filename, string fFirstTime, string fLastAccTime)
        {
            try
            {
                DataTable _myDataTable = new DataTable();
                // Get the file's text.
                //string whole_file = System.IO.File.ReadAllText("f:\\suez.csv");
                string whole_file = System.IO.File.ReadAllText(txt_input.Text + "\\" + filename);

                // Split into lines.
                whole_file = whole_file.Replace('\n', '\r');
                whole_file = whole_file.Replace(' ', ',');
                string[] lines = whole_file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
                lines = lines.Where(w => w != lines[0]).ToArray();
                lines = lines.Where(w => w != lines[0]).ToArray();
                // See how many rows and columns there are.
                int num_rows = lines.Length;
                //int num_cols = lines[2].Split(',').Length;
                int num_cols = 3;
                // Allocate the data array.
                string[,] values = new string[num_rows, num_cols];

                // Load the array.
                for (int r = 0; r < num_rows; r++)
                {
                    string[] line_r = lines[r].Split(',');

                    for (int c = 0; c < num_cols; c++)
                    {
                        if (c == 2) 
                        {
                            double no = Convert.ToDouble(line_r[c]);
                            double bar = no / 10.199773339984;
                            string newno = Math.Round(bar, 3).ToString();
                            values[r, c] = "\"" + newno + "\"";
                        }
                        else
                        { values[r, c] = "\"" + line_r[c] + "\""; }
                    }
                }
                // Return the values.
                //return values;

                //Convert Array to Datatable
                for (int i = 0; i < num_cols; i++)
                {
                    _myDataTable.Columns.Add();
                }

                check = Properties.Settings.Default["Check"].ToString();
                if (check == "") { check = "DESC"; }

                if (check == "ASC")
                {
                    for (int j = 0; j < num_rows; j++)
                    {
                        // create a DataRow using .NewRow()
                        DataRow row = _myDataTable.NewRow();

                        // iterate over all columns to fill the row
                        for (int i = 0; i < num_cols; i++)
                        {
                            row[i] = values[j, i];
                        }

                        // add the current row to the DataTable
                        _myDataTable.Rows.Add(row);
                    }
                }
                else if (check == "DESC")
                {
                    
                    for (int j = num_rows; j > 0; j--)
                    {
                        int k = 0;
                        // create a DataRow using .NewRow()
                        DataRow row = _myDataTable.NewRow();

                        // iterate over all columns to fill the row
                        for (int i = num_cols; i > 0; i--)
                        {
                            row[k] = values[j-1,i-1];
                            k++;
                        }

                        // add the current row to the DataTable
                        _myDataTable.Rows.Add(row);
                    }

                    List<int> indices = new List<int> { 2, 1, 0 };

                    for (int i = 0; i < indices.Count; i++)
                    {
                        _myDataTable.Columns[indices[i]].SetOrdinal(i);
                        if (indices[i] > i)
                        {
                            for (int j = i; j < indices.Count; j++)
                                if (indices[j] >= i && indices[j] < indices[i]) indices[j]++;//Right shifted                       
                        }
                        else if (indices[i] < i)
                        {
                            for (int j = i; j < indices.Count; j++)
                                if (indices[j] >= indices[i] && indices[j] < i) indices[j]--;//Left shifted
                        }
                    }     
                }
                

                createcsvtable(_myDataTable, filename);

                if ((System.IO.File.Exists(txt_input.Text + "\\" + filename)))
                {
                    string que="INSERT INTO Log_Csv (FileName,Date,Time,CSV,Process) VALUES ('"+filename+"','"+fFirstTime+"','"+fLastAccTime+"', '"+strFilePath+"','"+proc+"')";
                    SqlCommand comm = new SqlCommand(que, conn);
                    comm.ExecuteNonQuery();

                    if (proc != "Error")
                    {
                        string source = Path.Combine(txt_input.Text, filename);
                        string dest = Path.Combine(txt_errorpath.Text, filename);
                        File.Copy(@source, @dest, true);
                        System.IO.File.Delete(txt_input.Text + "\\" + filename);
                    }
                }
            }
            catch (Exception EX) 
            { 
                lblerror.Text = EX.Message.ToString(); 
                conn.Close();

                string source = Path.Combine(txt_input.Text, filename);
                string dest = Path.Combine(txt_errorpath.Text, filename);
                File.Copy(@source,@dest,true);
                System.IO.File.Delete(txt_input.Text + "\\" + filename);
            }
            
        }

        private void createcsvtable(DataTable _myDataTable, string filename)
        {
            check = Properties.Settings.Default["CSV"].ToString();
             //_myDataTable.Rows.RemoveAt(0);
                DataRow row1 = _myDataTable.NewRow();
                row1[0] = "\"" + siteID + "\"";
                row1[1] = "\"" + LogSN + "\"";

                if (string.IsNullOrEmpty(row1[0].ToString()) || string.IsNullOrEmpty(row1[1].ToString())) { proc = "Error"; }
                else
                {

                    _myDataTable.Rows.InsertAt(row1, 0);

                    DataRow row2 = _myDataTable.NewRow();
                    row2[0] = "\"" + "Date" + "\"";
                    row2[1] = "\"" + "Time" + "\"";
                    row2[2] = "\"" + "Average Pressure A1 (Bar)" + "\"";
                    _myDataTable.Rows.InsertAt(row2, 1);
                    proc = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                    string folderpath = txt_output.Text + "\\" + "0" + LogSN;
                    string filename2 = filename;
                    if (!Directory.Exists(folderpath))
                        Directory.CreateDirectory(folderpath);

                    if (LogSN.Length == 6) { strFilePath = folderpath + "\\" + LogSN + "_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + LogSN + ".csv"; }
                    else if (LogSN.Length == 5) { strFilePath = folderpath + "\\" + "0" + LogSN + "_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "0" + LogSN + ".csv"; }
                    else if (LogSN.Length == 4) { strFilePath = folderpath + "\\" + "00" + LogSN + "_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "00" + LogSN + ".csv"; }
                    //string strFilePath = txt_output.Text + "\\" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + LogSN + ".csv";
                    sw = new StreamWriter(strFilePath, false);

                    foreach (DataRow dr in _myDataTable.Rows)
                    {
                        for (int i = 0; i < _myDataTable.Columns.Count; i++)
                        {
                            if (!Convert.IsDBNull(dr[i]))
                            {
                                string value = dr[i].ToString();
                                if (value.Contains(','))
                                {
                                    value = String.Format("\"{0}\"", value);
                                    sw.Write(value);
                                }
                                else
                                {
                                    sw.Write(dr[i].ToString());
                                }
                            }
                            if (i < _myDataTable.Columns.Count - 1)
                            {
                                sw.Write(",");
                            }
                        }
                        sw.Write(sw.NewLine);
                    }
                    sw.Close();
                }
        }

        private void rd_csv_CheckedChanged(object sender, EventArgs e)
        {
            allfiles = System.IO.Directory.GetFiles(txt_input.Text, "*.csv", System.IO.SearchOption.AllDirectories);
        }

        private void rd_txt_CheckedChanged(object sender, EventArgs e)
        {
            allfiles = System.IO.Directory.GetFiles(txt_input.Text, "*.txt", System.IO.SearchOption.AllDirectories);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Server = Properties.Settings.Default["Server"].ToString();
            string DB = Properties.Settings.Default["Database"].ToString();
            string UserN = Properties.Settings.Default["UserName"].ToString();
            string Password = Properties.Settings.Default["Password"].ToString();
            string time = Properties.Settings.Default["Timer"].ToString();
            txt_input.Text = Properties.Settings.Default["Input"].ToString();
            txt_output.Text = Properties.Settings.Default["Output"].ToString();
            txt_errorpath.Text = Properties.Settings.Default["Error"].ToString();

            connectionstring = "Data Source=" + Server + ";MultipleActiveResultSets=true;Initial Catalog=" + DB + ";Persist Security Info=True;User ID=" + UserN + ";Password=" + Password + "";
        }

        private void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(process_Click);
            timer1.Interval = 5000; // in miliseconds
            timer1.Start();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.Show();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogDix log = new LogDix();
            log.Show();
        }

        private void bttn_stop_Click(object sender, EventArgs e)
        {
            bttn_start.Enabled = true;
            timer1.Stop();
        }

        private void process_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = connectionstring;
            conn.Open();

            if (rd_csv.Checked) { allfiles = System.IO.Directory.GetFiles(txt_input.Text, "*.csv", System.IO.SearchOption.AllDirectories); }
            else if (rd_txt.Checked) { allfiles = System.IO.Directory.GetFiles(txt_input.Text, "*.txt", System.IO.SearchOption.AllDirectories); }

            try
            {
                //lblerror.Text = (i++).ToString();
                Int32 i = 1; 
                foreach (var file in allfiles)
                {
                    if (conn.State != ConnectionState.Open) { conn.Open(); }
                    lbl_proc.Text = "Processing "+i + " of " + allfiles.Count();
                    FileInfo fInfo = new FileInfo(file);
                    string filename = fInfo.Name.ToString();
                    //
                    string[] parts = filename.Split('_');
                    string trmstr = parts[0].ToString();
                    //
                    //string trmstr = filename.Substring(0, 11);
                    string fFirstTime = fInfo.CreationTime.ToString();
                    string fLastAccTime = fInfo.LastAccessTime.ToString();
                    //string connectionstring = @"Data Source=DESKTOP-203834V\SQLEXPRESS;Initial Catalog=hwmdb;Persist Security Info=True;User ID=sa;Password=Enviro@123";

                    //SqlCommand comm = new SqlCommand("SELECT sites.SiteID, loggers.LoggerSerialNumber FROM loggers INNER JOIN sites ON loggers.ID = sites.ID WHERE (loggers.LoggerSMSNumber = " + trmstr + ")", conn);
                    SqlCommand comm = new SqlCommand("SELECT sites.SiteID, loggers.LoggerSerialNumber FROM loggers INNER JOIN sites ON loggers.ID = sites.ID WHERE (loggers.LoggerSerialNumber = " + trmstr + ")", conn);
                    SqlDataReader reader= comm.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            siteID = reader["SiteID"].ToString();
                            LogSN = reader["LoggerSerialNumber"].ToString();
                        }
                    }
                    finally
                    {
                        Readfile(filename, fFirstTime, fLastAccTime);
                        reader.Close(); 
                    }
                    //connectionstring = "Data Source=" + Server + ";MultipleActiveResultSets=true;Initial Catalog=" + DB + ";Persist Security Info=True;User ID=" + UserN + ";Password=" + Password + "";
                    i++;
                }
                //if (i > (allfiles.Count())) { lbl_proc.Text = "Completed"; }
            }
            catch (Exception Ex) { lblerror.Text = Ex.Message.ToString(); conn.Close(); }
            conn.Close();
           
        }

        private void fTPSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTP_Control ftpshow = new FTP_Control();
            ftpshow.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:info@envirosafetysolutions.in");
        }

        private void bttn_error_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                txt_errorpath.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
                Properties.Settings.Default["Error"] = txt_errorpath.Text;
                Properties.Settings.Default.Save();
            }
        }

    }
}
