namespace Clippy.SDK
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pbClipboard = new System.Windows.Forms.PictureBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoStretchImage = new System.Windows.Forms.RadioButton();
            this.rdoAutoSize = new System.Windows.Forms.RadioButton();
            this.rdoCenterImage = new System.Windows.Forms.RadioButton();
            this.rdoZoom = new System.Windows.Forms.RadioButton();
            this.pbDeviceIndependentBitmap = new System.Windows.Forms.PictureBox();
            this.pbPNG = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtWatchDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartFileSystemWatcher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbClipboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeviceIndependentBitmap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPNG)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClipboard
            // 
            this.pbClipboard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbClipboard.Location = new System.Drawing.Point(12, 34);
            this.pbClipboard.Name = "pbClipboard";
            this.pbClipboard.Size = new System.Drawing.Size(630, 230);
            this.pbClipboard.TabIndex = 0;
            this.pbClipboard.TabStop = false;
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.Location = new System.Drawing.Point(648, 34);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtData.Size = new System.Drawing.Size(442, 763);
            this.txtData.TabIndex = 1;
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Checked = true;
            this.rdoNormal.Location = new System.Drawing.Point(12, 12);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(59, 16);
            this.rdoNormal.TabIndex = 2;
            this.rdoNormal.TabStop = true;
            this.rdoNormal.Text = "Normal";
            this.rdoNormal.UseVisualStyleBackColor = true;
            this.rdoNormal.CheckedChanged += new System.EventHandler(this.RdoSizeMode_CheckedChanged);
            // 
            // rdoStretchImage
            // 
            this.rdoStretchImage.AutoSize = true;
            this.rdoStretchImage.Location = new System.Drawing.Point(77, 12);
            this.rdoStretchImage.Name = "rdoStretchImage";
            this.rdoStretchImage.Size = new System.Drawing.Size(90, 16);
            this.rdoStretchImage.TabIndex = 3;
            this.rdoStretchImage.Text = "StretchImage";
            this.rdoStretchImage.UseVisualStyleBackColor = true;
            this.rdoStretchImage.CheckedChanged += new System.EventHandler(this.RdoSizeMode_CheckedChanged);
            // 
            // rdoAutoSize
            // 
            this.rdoAutoSize.AutoSize = true;
            this.rdoAutoSize.Location = new System.Drawing.Point(173, 12);
            this.rdoAutoSize.Name = "rdoAutoSize";
            this.rdoAutoSize.Size = new System.Drawing.Size(68, 16);
            this.rdoAutoSize.TabIndex = 4;
            this.rdoAutoSize.Text = "AutoSize";
            this.rdoAutoSize.UseVisualStyleBackColor = true;
            this.rdoAutoSize.CheckedChanged += new System.EventHandler(this.RdoSizeMode_CheckedChanged);
            // 
            // rdoCenterImage
            // 
            this.rdoCenterImage.AutoSize = true;
            this.rdoCenterImage.Location = new System.Drawing.Point(247, 12);
            this.rdoCenterImage.Name = "rdoCenterImage";
            this.rdoCenterImage.Size = new System.Drawing.Size(87, 16);
            this.rdoCenterImage.TabIndex = 5;
            this.rdoCenterImage.Text = "CenterImage";
            this.rdoCenterImage.UseVisualStyleBackColor = true;
            this.rdoCenterImage.CheckedChanged += new System.EventHandler(this.RdoSizeMode_CheckedChanged);
            // 
            // rdoZoom
            // 
            this.rdoZoom.AutoSize = true;
            this.rdoZoom.Location = new System.Drawing.Point(340, 12);
            this.rdoZoom.Name = "rdoZoom";
            this.rdoZoom.Size = new System.Drawing.Size(51, 16);
            this.rdoZoom.TabIndex = 6;
            this.rdoZoom.Text = "Zoom";
            this.rdoZoom.UseVisualStyleBackColor = true;
            this.rdoZoom.CheckedChanged += new System.EventHandler(this.RdoSizeMode_CheckedChanged);
            // 
            // pbDeviceIndependentBitmap
            // 
            this.pbDeviceIndependentBitmap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbDeviceIndependentBitmap.Location = new System.Drawing.Point(12, 550);
            this.pbDeviceIndependentBitmap.Name = "pbDeviceIndependentBitmap";
            this.pbDeviceIndependentBitmap.Size = new System.Drawing.Size(630, 230);
            this.pbDeviceIndependentBitmap.TabIndex = 7;
            this.pbDeviceIndependentBitmap.TabStop = false;
            // 
            // pbPNG
            // 
            this.pbPNG.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbPNG.Location = new System.Drawing.Point(12, 292);
            this.pbPNG.Name = "pbPNG";
            this.pbPNG.Size = new System.Drawing.Size(630, 230);
            this.pbPNG.TabIndex = 8;
            this.pbPNG.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 270);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 16);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(12, 528);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 16);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // txtWatchDirectory
            // 
            this.txtWatchDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWatchDirectory.Location = new System.Drawing.Point(682, 11);
            this.txtWatchDirectory.Name = "txtWatchDirectory";
            this.txtWatchDirectory.Size = new System.Drawing.Size(327, 19);
            this.txtWatchDirectory.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "パス：";
            // 
            // btnStartFileSystemWatcher
            // 
            this.btnStartFileSystemWatcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartFileSystemWatcher.Location = new System.Drawing.Point(1015, 9);
            this.btnStartFileSystemWatcher.Name = "btnStartFileSystemWatcher";
            this.btnStartFileSystemWatcher.Size = new System.Drawing.Size(75, 23);
            this.btnStartFileSystemWatcher.TabIndex = 13;
            this.btnStartFileSystemWatcher.Text = "Watch開始";
            this.btnStartFileSystemWatcher.UseVisualStyleBackColor = true;
            this.btnStartFileSystemWatcher.Click += new System.EventHandler(this.BtnStartFileSystemWatcher_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 809);
            this.Controls.Add(this.btnStartFileSystemWatcher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWatchDirectory);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pbPNG);
            this.Controls.Add(this.pbDeviceIndependentBitmap);
            this.Controls.Add(this.rdoZoom);
            this.Controls.Add(this.rdoCenterImage);
            this.Controls.Add(this.rdoAutoSize);
            this.Controls.Add(this.rdoStretchImage);
            this.Controls.Add(this.rdoNormal);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.pbClipboard);
            this.Name = "MainForm";
            this.Text = "Clippy.SDK";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClipboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeviceIndependentBitmap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPNG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClipboard;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.RadioButton rdoStretchImage;
        private System.Windows.Forms.RadioButton rdoAutoSize;
        private System.Windows.Forms.RadioButton rdoCenterImage;
        private System.Windows.Forms.RadioButton rdoZoom;
        private System.Windows.Forms.PictureBox pbDeviceIndependentBitmap;
        private System.Windows.Forms.PictureBox pbPNG;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox txtWatchDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartFileSystemWatcher;
    }
}

