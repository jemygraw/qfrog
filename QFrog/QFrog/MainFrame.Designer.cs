namespace QFrog
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.OpenUploadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ChunkUploadTabPage = new System.Windows.Forms.TabPage();
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.UploadProgressBar = new System.Windows.Forms.ProgressBar();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.UploadButton = new System.Windows.Forms.Button();
            this.HaltButton = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.SettingsTabPage = new System.Windows.Forms.TabPage();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.SecretKeyTextBox = new System.Windows.Forms.TextBox();
            this.SecretKeyLabel = new System.Windows.Forms.Label();
            this.AccessKeyTextBox = new System.Windows.Forms.TextBox();
            this.AccessKeyLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BucketTextBox = new System.Windows.Forms.TextBox();
            this.BucketLabel = new System.Windows.Forms.Label();
            this.MainTabControl.SuspendLayout();
            this.ChunkUploadTabPage.SuspendLayout();
            this.MainGroupBox.SuspendLayout();
            this.SettingsTabPage.SuspendLayout();
            this.SettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenUploadFileDialog
            // 
            this.OpenUploadFileDialog.Title = "打开上传文件";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.ChunkUploadTabPage);
            this.MainTabControl.Controls.Add(this.SettingsTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(407, 260);
            this.MainTabControl.TabIndex = 0;
            // 
            // ChunkUploadTabPage
            // 
            this.ChunkUploadTabPage.Controls.Add(this.MainGroupBox);
            this.ChunkUploadTabPage.Location = new System.Drawing.Point(4, 22);
            this.ChunkUploadTabPage.Name = "ChunkUploadTabPage";
            this.ChunkUploadTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ChunkUploadTabPage.Size = new System.Drawing.Size(399, 234);
            this.ChunkUploadTabPage.TabIndex = 0;
            this.ChunkUploadTabPage.Text = "断点续传";
            this.ChunkUploadTabPage.UseVisualStyleBackColor = true;
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.UploadProgressBar);
            this.MainGroupBox.Controls.Add(this.LogTextBox);
            this.MainGroupBox.Controls.Add(this.UploadButton);
            this.MainGroupBox.Controls.Add(this.HaltButton);
            this.MainGroupBox.Controls.Add(this.BrowseButton);
            this.MainGroupBox.Controls.Add(this.FileNameTextBox);
            this.MainGroupBox.Location = new System.Drawing.Point(9, 5);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(380, 220);
            this.MainGroupBox.TabIndex = 1;
            this.MainGroupBox.TabStop = false;
            // 
            // UploadProgressBar
            // 
            this.UploadProgressBar.Location = new System.Drawing.Point(11, 167);
            this.UploadProgressBar.Name = "UploadProgressBar";
            this.UploadProgressBar.Size = new System.Drawing.Size(358, 6);
            this.UploadProgressBar.TabIndex = 4;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(11, 45);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(358, 116);
            this.LogTextBox.TabIndex = 3;
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(11, 182);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(75, 23);
            this.UploadButton.TabIndex = 5;
            this.UploadButton.Text = "上传";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // HaltButton
            // 
            this.HaltButton.Location = new System.Drawing.Point(294, 182);
            this.HaltButton.Name = "HaltButton";
            this.HaltButton.Size = new System.Drawing.Size(75, 23);
            this.HaltButton.TabIndex = 6;
            this.HaltButton.Text = "取消";
            this.HaltButton.UseVisualStyleBackColor = true;
            this.HaltButton.Click += new System.EventHandler(this.HaltButton_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(294, 15);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "浏览...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.FileNameTextBox.Location = new System.Drawing.Point(11, 15);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.ReadOnly = true;
            this.FileNameTextBox.Size = new System.Drawing.Size(277, 21);
            this.FileNameTextBox.TabIndex = 1;
            // 
            // SettingsTabPage
            // 
            this.SettingsTabPage.Controls.Add(this.SettingsGroupBox);
            this.SettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTabPage.Size = new System.Drawing.Size(399, 234);
            this.SettingsTabPage.TabIndex = 1;
            this.SettingsTabPage.Text = "设置";
            this.SettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.SecretKeyTextBox);
            this.SettingsGroupBox.Controls.Add(this.SecretKeyLabel);
            this.SettingsGroupBox.Controls.Add(this.AccessKeyTextBox);
            this.SettingsGroupBox.Controls.Add(this.AccessKeyLabel);
            this.SettingsGroupBox.Controls.Add(this.SaveButton);
            this.SettingsGroupBox.Controls.Add(this.BucketTextBox);
            this.SettingsGroupBox.Controls.Add(this.BucketLabel);
            this.SettingsGroupBox.Location = new System.Drawing.Point(9, 5);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(380, 220);
            this.SettingsGroupBox.TabIndex = 0;
            this.SettingsGroupBox.TabStop = false;
            // 
            // SecretKeyTextBox
            // 
            this.SecretKeyTextBox.Location = new System.Drawing.Point(81, 90);
            this.SecretKeyTextBox.Name = "SecretKeyTextBox";
            this.SecretKeyTextBox.Size = new System.Drawing.Size(284, 21);
            this.SecretKeyTextBox.TabIndex = 6;
            // 
            // SecretKeyLabel
            // 
            this.SecretKeyLabel.AutoSize = true;
            this.SecretKeyLabel.Location = new System.Drawing.Point(10, 94);
            this.SecretKeyLabel.Name = "SecretKeyLabel";
            this.SecretKeyLabel.Size = new System.Drawing.Size(65, 12);
            this.SecretKeyLabel.TabIndex = 5;
            this.SecretKeyLabel.Text = "Secret Key";
            // 
            // AccessKeyTextBox
            // 
            this.AccessKeyTextBox.Location = new System.Drawing.Point(81, 56);
            this.AccessKeyTextBox.Name = "AccessKeyTextBox";
            this.AccessKeyTextBox.Size = new System.Drawing.Size(284, 21);
            this.AccessKeyTextBox.TabIndex = 4;
            // 
            // AccessKeyLabel
            // 
            this.AccessKeyLabel.AutoSize = true;
            this.AccessKeyLabel.Location = new System.Drawing.Point(10, 59);
            this.AccessKeyLabel.Name = "AccessKeyLabel";
            this.AccessKeyLabel.Size = new System.Drawing.Size(65, 12);
            this.AccessKeyLabel.TabIndex = 3;
            this.AccessKeyLabel.Text = "Access Key";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(290, 185);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BucketTextBox
            // 
            this.BucketTextBox.Location = new System.Drawing.Point(81, 22);
            this.BucketTextBox.Name = "BucketTextBox";
            this.BucketTextBox.Size = new System.Drawing.Size(284, 21);
            this.BucketTextBox.TabIndex = 1;
            // 
            // BucketLabel
            // 
            this.BucketLabel.AutoSize = true;
            this.BucketLabel.Location = new System.Drawing.Point(46, 25);
            this.BucketLabel.Name = "BucketLabel";
            this.BucketLabel.Size = new System.Drawing.Size(29, 12);
            this.BucketLabel.TabIndex = 0;
            this.BucketLabel.Text = "空间";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 260);
            this.Controls.Add(this.MainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrame";
            this.Text = "七牛云存储-大文件上传";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.MainTabControl.ResumeLayout(false);
            this.ChunkUploadTabPage.ResumeLayout(false);
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.SettingsTabPage.ResumeLayout(false);
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenUploadFileDialog;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage ChunkUploadTabPage;
        private System.Windows.Forms.TabPage SettingsTabPage;
        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.ProgressBar UploadProgressBar;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Button HaltButton;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.TextBox SecretKeyTextBox;
        private System.Windows.Forms.Label SecretKeyLabel;
        private System.Windows.Forms.TextBox AccessKeyTextBox;
        private System.Windows.Forms.Label AccessKeyLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox BucketTextBox;
        private System.Windows.Forms.Label BucketLabel;
    }
}

