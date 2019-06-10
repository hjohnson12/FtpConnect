/*
 * Programmer: Hunter Johnson
 * Name: FTP Login
 * Date: 11/1/16 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace FTP_Connect
{
    public partial class frmFTP : Form
    {
        // global variables
        string filename;
        string filepath;

        public frmFTP()
        {
            InitializeComponent();
            statusLabel.Text = "Not currently logged into FTP Server.";
            statusListBox.Items.Add("Not currently logged into FTP Server.");
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (hostnameTextBox.Text == "" || usernameTextBox.Text == "" || passwordTextBox.Text == "") {
                MessageBox.Show("Make sure to enter a Hostname, Username, and Password.", "Connecting Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                directoriesListBox.Items.Clear();
                statusListBox.Items.Clear();

                // call ftpReadFiles()
                ftpReadFiles();
            }
        }
  

        private void ftpReadFiles()
        {
            try
            {
                // implement a file transfer protocol client
                //FtpWebRequest Request = (FtpWebRequest)WebRequest.Create(hostnameTextBox.Text);
                FtpWebRequest Request = (FtpWebRequest)WebRequest.Create("ftp://waws-prod-dm1-039.ftp.azurewebsites.windows.net");
                Request.Method = WebRequestMethods.Ftp.ListDirectory;     // request a list of the directory
                //Request.Credentials = new NetworkCredential(usernameTextBox.Text, passwordTextBox.Text);
                Request.Credentials = new NetworkCredential(@"technicallywright\twright", @"Password@12");   // initialize instance with specified username/password
                FtpWebResponse Response = (FtpWebResponse)Request.GetResponse();   // encapsulates a FTP server's response to a request
                Stream ResponseStream = Response.GetResponseStream();     // provides a generic review of a sequence of bytes - abstract class
                StreamReader Reader = new StreamReader(ResponseStream);  // reads characters from a byte stream in a particular encoding

                statusLabel.Text = Response.WelcomeMessage; // message when authentication is complete
                statusListBox.Items.Add(Response.WelcomeMessage);
                statusListBox.Items.Add("•" + Response.StatusDescription);
                while (!Reader.EndOfStream)//Read file name   
                {
                    directoriesListBox.Items.Add(Reader.ReadLine().ToString());
                }
                statusListBox.Items.Add("•" + Response.StatusDescription);

                // close the Response, ResponseStream, and Reader
                Response.Close();
                ResponseStream.Close();
                Reader.Close();
            }
            catch(Exception ex)
            {
                statusListBox.Items.Add("•" + ex.Message);
            }
        }

        public void DownloadFile(string ftpURL, string UserName, string Password, string ftpDirectory, string FileName, string LocalDirectory)
        {
            if (!File.Exists(LocalDirectory + "/" + FileName))
            {
                try
                {
                    // implement a file transfer protocol client
                    FtpWebRequest requestFileDownload = (FtpWebRequest)WebRequest.Create(ftpURL + "/" + ftpDirectory + "/" + FileName);
                    requestFileDownload.Credentials = new NetworkCredential(UserName, Password);  // pass the credentials
                    requestFileDownload.Method = WebRequestMethods.Ftp.DownloadFile;  // download file method
                    FtpWebResponse responseFileDownload = (FtpWebResponse)requestFileDownload.GetResponse();  // response method to the Download
                    Stream responseStream = responseFileDownload.GetResponseStream();   // contains the response data
                    FileStream writeStream = new FileStream(LocalDirectory + "/" + FileName, FileMode.Create);   // writes the file to the directory
                    int Length = 2048;
                    Byte[] buffer = new Byte[Length];
                    int bytesRead = responseStream.Read(buffer, 0, Length);
                    statusListBox.Items.Add("•" + responseFileDownload.StatusDescription);
                    while (bytesRead > 0)  // while there are bytes read
                    {
                        writeStream.Write(buffer, 0, bytesRead);
                        bytesRead = responseStream.Read(buffer, 0, Length);
                    }
                    statusListBox.Items.Add("•" + responseFileDownload.StatusDescription);
                    responseStream.Close();  // close the response stream
                    writeStream.Close(); // close the write stream
                    requestFileDownload = null;   // set to null, to allow a re-call of the function

                    successStatusLabel.Text = "Download Completed";
                }
                catch (Exception ex)
                {
                    statusListBox.Items.Add("•" + ex.Message);
                    successStatusLabel.Text = ex.Message;
                }
            }
        }


        public List<string> ShowFiles(string ftpURL, string UserName, string Password, string ftpDirectory)
        {
            // implement a file transfer protocol client
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpURL + "/" + ftpDirectory);
            request.Credentials = new NetworkCredential(UserName, Password);  // pass the credentials
            request.Method = WebRequestMethods.Ftp.ListDirectory;  // request a list of the directory
            FtpWebResponse Response = (FtpWebResponse)request.GetResponse();  // get the response message to the servers request
            StreamReader streamReader = new StreamReader(request.GetResponse().GetResponseStream());  // returns the response

            List<string> lines = new List<string>();
            string line;
            statusListBox.Items.Add("•" + Response.StatusDescription);
            // add the lines to the list
            while ((line = streamReader.ReadLine()) != null)
            {
                lines.Add(line); 
            }
            statusListBox.Items.Add("•" + Response.StatusDescription);
            streamReader.Close(); // close the StreamReader
            return lines;
        }

        public void UploadFileToFtp(string filePath, string username, string password)
        {
            try
            {
                string fileName = Path.GetFileName(filePath);
                var directoryPath = directoriesListBox.Text + "/" + contentsListBox.Text;
                // string path = hostnameTextBox.Text + "/" + directoryTextBox.Text + "/" + fileName;
                string path="ftp://waws-prod-dm1-039.ftp.azurewebsites.windows.net" + "/" + directoryPath + "/" + fileName;
                
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(path);
                request.Credentials = new NetworkCredential(username, password); // get the credentials

                request.Method = WebRequestMethods.Ftp.UploadFile;  // get the WebRequestMethod for uploading
                // required for data transfer
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;

                // to avoid having to manually close the fileStream and requestStream
                using (var fileStream = File.OpenRead(filePath))
                {
                    using (var requestStream = request.GetRequestStream())
                    {
                        fileStream.CopyTo(requestStream);  // copy the file to the stream
                        requestStream.Close();  // close the requestStream
                    }
                }

                FtpWebResponse Response = (FtpWebResponse)request.GetResponse();  // get the response request
                statusListBox.Items.Add("•" + Response.StatusDescription);
                Response.Close();  // close the response
                successStatusLabel.Text = "Upload Complete";
            }
            catch(Exception ex)
            {
                statusListBox.Items.Add("•" + ex.Message);
                successStatusLabel.Text = ex.Message;
            }
        }

        public void DeleteFile(string ftpURL, string UserName, string Password, string ftpDirectory, string FileName)
        {
            // implement a file transfer protocol client
            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(ftpURL + "/" + ftpDirectory + "/" + FileName);
            ftpRequest.Credentials = new NetworkCredential(UserName, Password);  // new instance with specified username/password
            ftpRequest.Method = WebRequestMethods.Ftp.DeleteFile;   // use the DeleteFile method
            FtpWebResponse responseFileDelete = (FtpWebResponse)ftpRequest.GetResponse();  // encapsulates a FTP server's response to a request
            statusListBox.Items.Add("•" + responseFileDelete.StatusDescription);
        }

    
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            directoryTextBox.Text = contentsListBox.SelectedItem.ToString();
            contentsListBox2.Items.Clear();
            filenameTextBox.Clear();
            successStatusLabel.Text = "";
            var direct = directoriesListBox.SelectedItem.ToString() + "/" + contentsListBox.Text;
            // show the files
            //List<string> files = ShowFiles(hostnameTextBox.Text, usernameTextBox.Text, passwordTextBox.Text, contentsListBox.Text);
            List<string> files = ShowFiles("ftp://waws-prod-dm1-039.ftp.azurewebsites.windows.net", @"technicallywright\twright", "Password@12", direct);
            directoryTextBox.Text = contentsListBox.Text;           
            foreach (string item in files)
            {
                contentsListBox2.Items.Add(item);
            }
        }

        private void directoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            contentsListBox.Items.Clear();
            //List<string> files = ShowFiles(hostnameTextBox.Text, usernameTextBox.Text, passwordTextBox.Text, directoriesListBox.Text);
            List<string> files = ShowFiles("ftp://waws-prod-dm1-039.ftp.azurewebsites.windows.net", @"technicallywright\twright", "Password@12", directoriesListBox.Text);
            foreach (string item in files)
            {
                contentsListBox.Items.Add(item);
            }
        }

        private void contentsListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               //directoryTextBox.Text = contentsListBox2.SelectedItem.ToString();
                filenameTextBox.Text = Path.GetFileName(contentsListBox2.SelectedItem.ToString());
                // show the files
                //List<string> files = ShowFiles(hostnameTextBox.Text, usernameTextBox.Text, passwordTextBox.Text, directoryTextBox.Text + "/" + filenameTextBox.Text);
                List<string> files = ShowFiles("ftp://waws-prod-dm1-039.ftp.azurewebsites.windows.net", @"technicallywright\twright", "Password@12", directoriesListBox.Text + "/" + directoryTextBox.Text + "/" + filenameTextBox.Text); //"public_html/" + listBox1.Text
                contentsListBox2.Items.Clear();
                foreach (string item in files)
                {
                    contentsListBox2.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                statusListBox.Items.Add(ex.Message);
            }      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // to disable re-sizing of the form
            MinimizeBox = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            // show tooltip
            hostnameToolTip.SetToolTip(hostnameTextBox, "Ex: ftp://111.111.111.111/");
            downloadToolTip.SetToolTip(downloadPictureBox, "Download File");
            uploadToolTip.SetToolTip(uploadPictureBox, "Upload File");
            deleteToolTip.SetToolTip(deletePictureBox, "Delete File");
        }

        private void openFilePictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();  // show the dialog

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // get the filepath
                filepath = openFileDialog1.FileName;
                // get the filename
                filename = Path.GetFileName(filepath);
                fileNameLabel.Text = filename;
            }
        }

        private void openFolderPictureBox_Click(object sender, EventArgs e)
        {
            string destinationPath;
            // if the user made a selection
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // set the selected path to the destination paths
                destinationPath = folderBrowserDialog1.SelectedPath;
                destinationPathLabel.Text = destinationPath;
            }
        }

        private void uploadPictureBox_Click(object sender, EventArgs e)
        {
            successStatusLabel.Text = "";

            //UploadFileToFtp(filepath, usernameTextBox.Text, passwordTextBox.Text);
            UploadFileToFtp(filepath, @"technicallywright\twright", "Password@12");           
        }

        private void deletePictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                successStatusLabel.Text = "";
                var directoryPath = directoriesListBox.Text + "/" + contentsListBox.Text;
                // DeleteFile(hostnameTextBox.Text, usernameTextBox.Text, passwordTextBox.Text, directoryTextBox.Text, filenameTextBox.Text);
                DeleteFile("ftp://waws-prod-dm1-039.ftp.azurewebsites.windows.net", @"technicallywright\twright", "Password@12", directoryPath, filenameTextBox.Text);
                successStatusLabel.Text = "Delete Successful";
            }
            catch (Exception ex)
            {
                successStatusLabel.Text = ex.Message;
            }
        }

        private void downloadPictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                if (destinationPathLabel.Text == "No Path Selected")
                {
                    MessageBox.Show("Please enter a destination path.", "Choose Destinaion Path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (filenameTextBox.Text == "")
                {
                    MessageBox.Show("Please enter a file name to download/delete.", "Choose File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(directoryTextBox.Text == "")
                {
                    MessageBox.Show("Please choose a directory.", "Choose Directory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    successStatusLabel.Text = "";
                    var directoryPath = directoriesListBox.Text + "/" + contentsListBox.Text; // Directory path
                    //DownloadFile(hostnameTextBox.Text, usernameTextBox.Text, passwordTextBox.Text, directoryTextBox.Text, filenameTextBox.Text, destinationPathLabel.Text);
                    DownloadFile("ftp://waws-prod-dm1-039.ftp.azurewebsites.windows.net", @"technicallywright\twright", "Password@12", directoryPath, filenameTextBox.Text, destinationPathLabel.Text);
                    successStatusLabel.Text = "Download Successful";
                }
            }
            catch (Exception ex)
            {
                successStatusLabel.Text = ex.Message;
            }
        }
    }
}
