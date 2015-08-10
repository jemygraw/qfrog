using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Qiniu.Storage;
using Qiniu.Storage.Persistent;
using System.IO;
using Qiniu.Util;
using Qiniu.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Qiniu.Storage.Model;

namespace QFrog
{
    public partial class MainFrame : Form
    {
        private bool cancelSignal;
        public MainFrame()
        {
            InitializeComponent();
            this.cancelSignal = false;
            this.UploadProgressBar.Maximum = 100;
            this.UploadButton.Enabled = true;
            this.HaltButton.Enabled = false;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.OpenUploadFileDialog.ShowDialog(this);
            if (dr.Equals(DialogResult.OK))
            {
                this.FileNameTextBox.Text = this.OpenUploadFileDialog.FileName;
            }
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            string filePath = this.FileNameTextBox.Text.Trim();
            string fileName = Path.GetFileName(filePath);
            string bucket = QFrog.Settings.Default.BUCKET;
            string accessKey = QFrog.Settings.Default.ACCESS_KEY;
            string secretKey = QFrog.Settings.Default.SECRET_KEY;
            this.LogTextBox.Text = "";
            Task.Factory.StartNew(() =>
            {
                try
                {
                    uploadFile(filePath, fileName, bucket, accessKey, secretKey);
                }
                catch (Exception)
                {
                    appendLog("上传遇到网络问题，请点击上传重试。");
                }
            });
        }

        private void uploadFile(string filePath, string fileName, string bucket, string accessKey, string secretKey)
        {
            this.cancelSignal = false;
            updateProgress(0);
            //check if file exists in the bucket
            appendLog("正在检查空间中是否存在同名文件...");
            Mac mac = new Mac(accessKey, secretKey);
            BucketManager manager = new BucketManager(mac);
            StatResult statResult = manager.stat(bucket, fileName);
            if (!string.IsNullOrEmpty(statResult.Hash))
            {
                appendLog("该文件已存在，如需上传同名文件，请先从远程删除");
            }
            else
            {
                if (statResult.ResponseInfo.StatusCode == 612)
                {
                    appendLog("空间中不存在同名文件，计算文件hash中...");
                    string qetag = QETag.hash(filePath);
                    if (!string.IsNullOrEmpty(qetag))
                    {
                        appendLog("文件hash为:" + qetag);
                        PutPolicy putPolicy = new PutPolicy();
                        putPolicy.Scope = bucket;
                        putPolicy.SetExpires(30 * 24 * 60 * 60);
                        string uploadToken = Auth.createUploadToken(putPolicy, mac);
                        upload(filePath, fileName, qetag, uploadToken);
                    }
                }
                else
                {
                    appendLog("获取同名文件信息失败!" + statResult.ResponseInfo.Error);
                }
            }
        }

        private void upload(string filePath, string fileName, string qetag, string uploadToken)
        {
            //set button state
            toggleButtonState(UploadButton, false);
            toggleButtonState(HaltButton, true);

            string recordKey = StringUtils.urlSafeBase64Encode(qetag + ":" + fileName);
            ResumeRecorder recorder = new ResumeRecorder("record");
            UploadManager uploadManager = new UploadManager(recorder, new KeyGenerator(delegate() { return recordKey; }));
            UploadOptions uploadOptions = UploadOptions.defaultOptions();
            uploadOptions.ProgressHandler = new UpProgressHandler(delegate(string key, double percent)
            {
                updateProgress(percent);
            });
            uploadOptions.CancellationSignal = new UpCancellationSignal(delegate() { return this.cancelSignal; });
            UpCompletionHandler upCompletionHandler = new UpCompletionHandler(delegate(string key, ResponseInfo respInfo, string response)
            {
                if (respInfo.isOk())
                {
                    appendLog("文件上传成功!");
                }
                else
                {
                    appendLog("文件上传失败,原因如下:");
                    appendLog(respInfo.ToString());
                }
                toggleButtonState(UploadButton, true);
                toggleButtonState(HaltButton, false);
            });
            appendLog("正在上传...");
            uploadManager.uploadFile(filePath, fileName, uploadToken, uploadOptions, upCompletionHandler);
        }

        private void HaltButton_Click(object sender, EventArgs e)
        {
            this.cancelSignal = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            QFrog.Settings.Default.BUCKET = this.BucketTextBox.Text.Trim();
            QFrog.Settings.Default.ACCESS_KEY = this.AccessKeyTextBox.Text.Trim();
            QFrog.Settings.Default.SECRET_KEY = this.SecretKeyTextBox.Text.Trim();
            QFrog.Settings.Default.Save();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            this.BucketTextBox.Text = QFrog.Settings.Default.BUCKET;
            this.AccessKeyTextBox.Text = QFrog.Settings.Default.ACCESS_KEY;
            this.SecretKeyTextBox.Text = QFrog.Settings.Default.SECRET_KEY;
        }

        private delegate void appendLogCallback(string message);
        private void appendLog(string message)
        {
            if (this.InvokeRequired)
            {
                appendLogCallback callback = new appendLogCallback(appendLog);
                this.Invoke(callback, message);
            }
            else
            {
                this.LogTextBox.AppendText(message + "\r\n");
            }
        }

        private delegate void updateProgressCallback(double percent);
        private void updateProgress(double percent)
        {
            if (this.InvokeRequired)
            {
                updateProgressCallback callback = new updateProgressCallback(updateProgress);
                this.Invoke(callback, percent);
            }
            else
            {
                int progress = (int)(percent * 100);
                this.UploadProgressBar.Value = progress;
            }
        }

        private delegate void toggleButtonStateCallback(Button button, bool enabled);
        private void toggleButtonState(Button button, bool enabled)
        {
            if (this.InvokeRequired)
            {
                toggleButtonStateCallback callback = new toggleButtonStateCallback(toggleButtonState);
                this.Invoke(callback, button, enabled);
            }
            else
            {
                button.Enabled = enabled;
            }
        }
    }
}
