using Amazon;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using MySql.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Configuration;
using System.IO;
using System.Net.NetworkInformation;
using static Mysqlx.Error.Types;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RoutineTaskUtility
{
    public partial class Form1 : Form
    {

        //private SqlConnection sqlConn;
        public Form1()
        {
            InitializeComponent();

            DBConnectionStatusLabel.Text = "Not Connected";
            DBConnectionStatusLabel.ForeColor = System.Drawing.Color.Black;

            FromdateTimePicker.Value = DateTime.Today.AddDays(-1);
            TodateTimePicker.Value = DateTime.Today;            
            
        }

        private void dSTReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rejectedReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manualRelayReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tCPerAgentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pWAFEditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pWAFUploadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (sqlConn is not null)
            //{
            //    if (sqlConn.State == System.Data.ConnectionState.Open)
            //    {
            //        sqlConn.Close();
            //        sqlConn.Dispose();
            //    }
            //}

        }

        private async void connectToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Working code below, however cannot resolve credentials "root" being used as found from HeidiSQL.

            //var pwd = Amazon.RDS.Util.RDSAuthTokenGenerator.GenerateAuthToken(RegionEndpoint.APSoutheast1, "", , "");
            //MessageBox.Show($"value: {pwd}");

            //Error:
            //Amazon.Runtime.AmazonClientException: 'Failed to resolve AWS credentials. The credential providers used to search for credentials returned the following errors:
            //Exception 1 of 4: The environment variables AWS_ACCESS_KEY_ID/ AWS_SECRET_ACCESS_KEY / AWS_SESSION_TOKEN were not set with AWS credentials.
            //Exception 2 of 4: The webIdentityTokenFile must be an absolute path. (Parameter 'webIdentityTokenFile')
            //Exception 3 of 4: Unable to find the "default" profile.
            //Exception 4 of 4: Failed to connect to EC2 instance metadata to retrieve credentials: Unable to get IAM security credentials from EC2 Instance Metadata Service..


            //NOT WORKING CONNECTIONS!
            //MySqlConnection conn = new MySqlConnection("server=;user=;database=;port=3306;password=;SslMode=Required;SslCa=D:\\SSLCertificates\\ap-southeast-1-bundle.p7b");

            //MySqlConnection conn = new MySqlConnection("server=;user=;database=;port=3306;password=");            

            //MySqlConnection conn = new MySqlConnection("server=;user=;database=;port=3306;password={pwd};SslMode=Required;SslCa=D://SSLCertificates//ap-southeast-1-bundle.p7b");

            //Working connection, however still with errors!          
            //MySqlConnection conn = new MySqlConnection("server=;user=;database=;port=3306;password=;SslMode=disabled");

            MySqlConnection conn = new MySqlConnection("server=;user=;database=;port=3306;password=;SslMode=disabled");

            //Error:           

            richTextBoxLogMessage.AppendText("Reading database configuration.\r\n");

            MySqlDataReader? mysqlDataRdr = null;

            try
            {

                richTextBoxLogMessage.AppendText("Trying to connect to database.\r\n");
                DBConnectionStatusLabel.Text = "Connecting";
                DBConnectionStatusLabel.ForeColor = System.Drawing.Color.Orange;

                await Task.Run(() =>
                {
                    conn.Open();

                    MySqlCommand sampleCommand = new MySqlCommand("SHOW DATABASES;", conn);

                    mysqlDataRdr = sampleCommand.ExecuteReader();

                    while (mysqlDataRdr.Read())
                    {
                        //MessageBox.Show($"database: {mysqlDataRdr[0]}");
                        richTextBoxLogMessage.AppendText($"{mysqlDataRdr[0]}\r\n");

                        DBConnectionStatusLabel.Text = "Connected";
                        DBConnectionStatusLabel.ForeColor = System.Drawing.Color.Green;
                    }

                });
            }

            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");
                richTextBoxLogMessage.AppendText($"Error connecting to database: {ex.Message}\r\n");
                DBConnectionStatusLabel.Text = "Connection Error";
                DBConnectionStatusLabel.ForeColor = System.Drawing.Color.Red;
            }

            finally
            {
                if (conn != null && mysqlDataRdr != null)
                {
                    mysqlDataRdr.Close();
                    conn.Close();

                    richTextBoxLogMessage.AppendText("Closing database connection.\r\n");
                }
            }
        }

        private void RootFolderSelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            folderBrowserDialog.Description = "Select root folder to create folder reports.";
            folderBrowserDialog.ShowNewFolderButton = false;
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Personal;

            folderBrowserDialog.ShowDialog();

            selectedPathLabel.Text = folderBrowserDialog.SelectedPath;
        }

        private void CreateFoldersButton_Click(object sender, EventArgs e)
        {
            //if (selectedPathLabel.ToString().CompareTo("Empty"))
            //{
            //    MessageBox.Show("Cannot proceed, select path.");
            //}

            //if (string.IsNullOrEmpty(selectedPathLabel.Text))
            //{
            //    MessageBox.Show("Please select path first.");
            //}            

            var selectedSBUType = new List<string?>();
            var selectedReportsToGenerate = new List<string?>();

            foreach(var sbu in SBUCheckedListBox.CheckedItems)
            {
                if (sbu.ToString() is not null)
                {
                    selectedSBUType.Add(sbu.ToString());
                }                
            }

            foreach (var sbu in ReportGenerateCheckedListBox.CheckedItems)
            {
                if (sbu.ToString() is not null)
                {
                    selectedReportsToGenerate.Add(sbu.ToString());
                }
            }

            if (RunValidations(selectedSBUType, selectedReportsToGenerate))
            {
                if(CheckFolders(selectedSBUType, selectedReportsToGenerate))
                {
                    //MessageBox.Show("Folders successfully created!");
                    richTextBoxLogMessage.AppendText("Folders successfully created!\r\n");
                }
                
            }

            //MessageBox.Show($"database: {selectedPathLabel.Text}\r\n" +
            //    $"Selected SBU Type: {string.Join(", ", selectedSBUType)}\r\n" +
            //    $"Report to Generate: {string.Join(", ", selectedReportsToGenerate)} \r\n" +
            //    $"Date Range: {FromdateTimePicker.Value} - {TodateTimePicker.Value}");
        }

        private bool RunValidations(List<string?> SelectedSBUType, List<string?> SelectedReportsToGenerate)
        {
            if (selectedPathLabel.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please select root path to generate report.");
                return false;
            }
            else if (SelectedSBUType.IsNullOrEmpty())
            {
                MessageBox.Show("Please select atleast 1 SBU Type to generate.");
                return false;
            }
            else if (SelectedReportsToGenerate.IsNullOrEmpty())
            {
                MessageBox.Show("Please select atleast 1 Report Type to generate.");
                return false;
            }
            else if (!FromdateTimePicker.Checked)
            {
                MessageBox.Show("Plesae select date from.");
                return false;
            }
            else if (!TodateTimePicker.Checked)
            {
                MessageBox.Show("Please select date to.");
                return false;
            }
                return true;
        }

        private bool CheckFolders(List<string?> SelectedSBUType, List<string?> SelectedReportsToGenerate)
        {
            if (Directory.Exists(selectedPathLabel.Text))
            {                

                //check individual reports type to be generated whether 1) dst report 2) rejected report 3) manual relay report 4) tc per agent report
                foreach (var Reports in SelectedReportsToGenerate)
                {
                    if (Reports == null)
                    {
                        return false;
                    }
                    else
                    {
                        //check if sbu folder to be created is for 1) jollibee 2) greenwich
                        foreach (var SBU in SelectedSBUType)
                        {

                            if (SBU == null)
                            {
                                return false;
                            }
                            else
                            {
                                if (SBU.ToString().ToUpper().Equals("JOLLIBEE"))
                                {
                                    CreateFolders("JB", Reports);
                                }
                                else if (SBU.ToString().ToUpper().Equals("GREENWICH"))
                                {
                                    CreateFolders("GW", Reports);
                                }
                            }

                        }

                    }
                }
            }

            return true;
        }

        private void CreateFolders(string SBUType, string ReportType)
        {                        

            string ReportMonth = FromdateTimePicker.Value.ToString("MMMM");
            string ReportYear = FromdateTimePicker.Value.Year.ToString();
            string StartDay = FromdateTimePicker.Value.Day.ToString();
            string EndDay = TodateTimePicker.Value.Day.ToString();

            if (ReportType.ToUpper().Equals("DST REPORT"))
            {

                string FolderDirectoryStructure = "\\Detailed DST Report(" +ReportMonth + " " + StartDay + "-" + EndDay + ", " + ReportYear + ")\\" + SBUType + "_Detailed_DST_Report(" + ReportMonth + " " + StartDay + "-" + EndDay + ", " + ReportYear + ")";
                
                //MessageBox.Show($"complete directory: {selectedPathLabel.Text +FolderDirectoryStructure}");
                Directory.CreateDirectory(selectedPathLabel.Text + FolderDirectoryStructure);
            }
            else if(ReportType.ToUpper().Equals("REJECTED REPORT"))
            {
                string FolderDirectoryStructure = "\\Rejected Orders Report(" + ReportMonth + " " + StartDay + "-" + EndDay + ", " + ReportYear + ")\\" + SBUType + "_Rejected Orders Report(" + ReportMonth + " " + StartDay + "-" + EndDay + ", " + ReportYear + ")";

                //MessageBox.Show($"complete directory: {selectedPathLabel.Text + FolderDirectoryStructure}");
                Directory.CreateDirectory(selectedPathLabel.Text + FolderDirectoryStructure);
            }
            else if (ReportType.ToUpper().Equals("MANUAL RELAY REPORT"))
            {
                string FolderDirectoryStructure = "\\Manual Relayed Report(" + ReportMonth + " " + StartDay + "-" + EndDay + ", " + ReportYear + ")\\" + SBUType + "_Manual Relayed Report(" + ReportMonth + " " + StartDay + "-" + EndDay + ", " + ReportYear + ")";

                //MessageBox.Show($"complete directory: {selectedPathLabel.Text + FolderDirectoryStructure}");
                Directory.CreateDirectory(selectedPathLabel.Text + FolderDirectoryStructure);
            }
            else if (ReportType.ToUpper().Equals("TC PER AGENT REPORT"))
            {
                string FolderDirectoryStructure = "\\TC Per Agent Report(" + ReportMonth + " " + StartDay + "-" + EndDay + ", " + ReportYear + ")\\" + SBUType + "_TC Per Agent Report(" + ReportMonth + " " + StartDay + "-" + EndDay + ", " + ReportYear + ")";

                //MessageBox.Show($"complete directory: {selectedPathLabel.Text + FolderDirectoryStructure}");
                Directory.CreateDirectory(selectedPathLabel.Text + FolderDirectoryStructure);
            }
        }

        private bool CreateZipFile(string FolderLocation)
        {
            return true;
        }
    }
}
