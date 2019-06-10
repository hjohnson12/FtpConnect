namespace FTP_Connect
{
    partial class frmFTP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFTP));
            this.directoriesListBox = new System.Windows.Forms.ListBox();
            this.statusListBox = new System.Windows.Forms.ListBox();
            this.contentsListBox = new System.Windows.Forms.ListBox();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contentsListBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.hostnameTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uploadPictureBox = new System.Windows.Forms.PictureBox();
            this.deletePictureBox = new System.Windows.Forms.PictureBox();
            this.downloadPictureBox = new System.Windows.Forms.PictureBox();
            this.openFilePictureBox = new System.Windows.Forms.PictureBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.destinationPathLabel = new System.Windows.Forms.Label();
            this.openFolderPictureBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.successStatusLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hostnameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.downloadToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.uploadToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.deleteToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFolderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // directoriesListBox
            // 
            this.directoriesListBox.FormattingEnabled = true;
            this.directoriesListBox.HorizontalScrollbar = true;
            this.directoriesListBox.Location = new System.Drawing.Point(12, 143);
            this.directoriesListBox.Name = "directoriesListBox";
            this.directoriesListBox.Size = new System.Drawing.Size(420, 173);
            this.directoriesListBox.TabIndex = 3;
            this.directoriesListBox.SelectedIndexChanged += new System.EventHandler(this.directoriesListBox_SelectedIndexChanged);
            // 
            // statusListBox
            // 
            this.statusListBox.FormattingEnabled = true;
            this.statusListBox.HorizontalScrollbar = true;
            this.statusListBox.Location = new System.Drawing.Point(12, 322);
            this.statusListBox.Name = "statusListBox";
            this.statusListBox.Size = new System.Drawing.Size(894, 95);
            this.statusListBox.TabIndex = 10;
            // 
            // contentsListBox
            // 
            this.contentsListBox.FormattingEnabled = true;
            this.contentsListBox.Location = new System.Drawing.Point(460, 143);
            this.contentsListBox.Name = "contentsListBox";
            this.contentsListBox.Size = new System.Drawing.Size(446, 173);
            this.contentsListBox.TabIndex = 12;
            this.contentsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.Location = new System.Drawing.Point(153, 38);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(147, 20);
            this.filenameTextBox.TabIndex = 13;
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Location = new System.Drawing.Point(6, 38);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.Size = new System.Drawing.Size(141, 20);
            this.directoryTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Directory Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(153, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "File to Download/Delete:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(444, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Destination Path:";
            // 
            // contentsListBox2
            // 
            this.contentsListBox2.FormattingEnabled = true;
            this.contentsListBox2.HorizontalScrollbar = true;
            this.contentsListBox2.Location = new System.Drawing.Point(934, 149);
            this.contentsListBox2.Name = "contentsListBox2";
            this.contentsListBox2.Size = new System.Drawing.Size(282, 264);
            this.contentsListBox2.TabIndex = 19;
            this.contentsListBox2.SelectedIndexChanged += new System.EventHandler(this.contentsListBox2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Controls.Add(this.hostnameTextBox);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 125);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect to FTP Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hostname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Username:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(283, 42);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(127, 20);
            this.passwordTextBox.TabIndex = 14;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(147, 42);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(127, 20);
            this.usernameTextBox.TabIndex = 13;
            // 
            // hostnameTextBox
            // 
            this.hostnameTextBox.Location = new System.Drawing.Point(10, 42);
            this.hostnameTextBox.Name = "hostnameTextBox";
            this.hostnameTextBox.Size = new System.Drawing.Size(127, 20);
            this.hostnameTextBox.TabIndex = 12;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(332, 75);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(78, 35);
            this.connectButton.TabIndex = 11;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusLabel.Location = new System.Drawing.Point(10, 75);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(316, 35);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uploadPictureBox);
            this.groupBox2.Controls.Add(this.deletePictureBox);
            this.groupBox2.Controls.Add(this.downloadPictureBox);
            this.groupBox2.Controls.Add(this.openFilePictureBox);
            this.groupBox2.Controls.Add(this.fileNameLabel);
            this.groupBox2.Controls.Add(this.destinationPathLabel);
            this.groupBox2.Controls.Add(this.openFolderPictureBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.successStatusLabel);
            this.groupBox2.Controls.Add(this.filenameTextBox);
            this.groupBox2.Controls.Add(this.directoryTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(460, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 125);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Download/Upload/Delete File";
            // 
            // uploadPictureBox
            // 
            this.uploadPictureBox.BackColor = System.Drawing.Color.White;
            this.uploadPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("uploadPictureBox.Image")));
            this.uploadPictureBox.Location = new System.Drawing.Point(59, 72);
            this.uploadPictureBox.Name = "uploadPictureBox";
            this.uploadPictureBox.Size = new System.Drawing.Size(37, 38);
            this.uploadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uploadPictureBox.TabIndex = 29;
            this.uploadPictureBox.TabStop = false;
            this.uploadPictureBox.Click += new System.EventHandler(this.uploadPictureBox_Click);
            // 
            // deletePictureBox
            // 
            this.deletePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("deletePictureBox.Image")));
            this.deletePictureBox.Location = new System.Drawing.Point(109, 72);
            this.deletePictureBox.Name = "deletePictureBox";
            this.deletePictureBox.Size = new System.Drawing.Size(37, 38);
            this.deletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deletePictureBox.TabIndex = 28;
            this.deletePictureBox.TabStop = false;
            this.deletePictureBox.Click += new System.EventHandler(this.deletePictureBox_Click);
            // 
            // downloadPictureBox
            // 
            this.downloadPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downloadPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("downloadPictureBox.Image")));
            this.downloadPictureBox.Location = new System.Drawing.Point(9, 72);
            this.downloadPictureBox.Name = "downloadPictureBox";
            this.downloadPictureBox.Size = new System.Drawing.Size(37, 38);
            this.downloadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.downloadPictureBox.TabIndex = 27;
            this.downloadPictureBox.TabStop = false;
            this.downloadPictureBox.Click += new System.EventHandler(this.downloadPictureBox_Click);
            // 
            // openFilePictureBox
            // 
            this.openFilePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("openFilePictureBox.Image")));
            this.openFilePictureBox.Location = new System.Drawing.Point(319, 72);
            this.openFilePictureBox.Name = "openFilePictureBox";
            this.openFilePictureBox.Size = new System.Drawing.Size(34, 34);
            this.openFilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openFilePictureBox.TabIndex = 26;
            this.openFilePictureBox.TabStop = false;
            this.openFilePictureBox.Click += new System.EventHandler(this.openFilePictureBox_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileNameLabel.Location = new System.Drawing.Point(356, 76);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(271, 27);
            this.fileNameLabel.TabIndex = 25;
            this.fileNameLabel.Text = "No File Selected";
            this.fileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // destinationPathLabel
            // 
            this.destinationPathLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.destinationPathLabel.Location = new System.Drawing.Point(356, 27);
            this.destinationPathLabel.Name = "destinationPathLabel";
            this.destinationPathLabel.Size = new System.Drawing.Size(271, 27);
            this.destinationPathLabel.TabIndex = 24;
            this.destinationPathLabel.Text = "No Path Selected";
            this.destinationPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFolderPictureBox
            // 
            this.openFolderPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openFolderPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("openFolderPictureBox.Image")));
            this.openFolderPictureBox.Location = new System.Drawing.Point(319, 22);
            this.openFolderPictureBox.Name = "openFolderPictureBox";
            this.openFolderPictureBox.Size = new System.Drawing.Size(34, 34);
            this.openFolderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openFolderPictureBox.TabIndex = 23;
            this.openFolderPictureBox.TabStop = false;
            this.openFolderPictureBox.Click += new System.EventHandler(this.openFolderPictureBox_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(446, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "File to Upload:";
            // 
            // successStatusLabel
            // 
            this.successStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.successStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successStatusLabel.Location = new System.Drawing.Point(152, 72);
            this.successStatusLabel.Name = "successStatusLabel";
            this.successStatusLabel.Size = new System.Drawing.Size(161, 50);
            this.successStatusLabel.TabIndex = 22;
            this.successStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(433, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(907, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 424);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1228, 5);
            this.panel2.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 7);
            this.panel1.TabIndex = 26;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmFTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1228, 429);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.contentsListBox2);
            this.Controls.Add(this.contentsListBox);
            this.Controls.Add(this.statusListBox);
            this.Controls.Add(this.directoriesListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFolderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox directoriesListBox;
        private System.Windows.Forms.ListBox statusListBox;
        private System.Windows.Forms.ListBox contentsListBox;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox contentsListBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox hostnameTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label successStatusLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip hostnameToolTip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label destinationPathLabel;
        private System.Windows.Forms.PictureBox openFolderPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox openFilePictureBox;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.PictureBox downloadPictureBox;
        private System.Windows.Forms.PictureBox deletePictureBox;
        private System.Windows.Forms.PictureBox uploadPictureBox;
        private System.Windows.Forms.ToolTip downloadToolTip;
        private System.Windows.Forms.ToolTip uploadToolTip;
        private System.Windows.Forms.ToolTip deleteToolTip;
    }
}

