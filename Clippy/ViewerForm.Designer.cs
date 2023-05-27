namespace Clippy
{
    partial class ViewerForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewerForm));
            this.dgvRepository = new System.Windows.Forms.DataGridView();
            this.ColNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.llOpenSaveDir = new System.Windows.Forms.LinkLabel();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.cmsRepository = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmsiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetting = new System.Windows.Forms.Button();
            this.pictureBox = new Clippy.MyPictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepository)).BeginInit();
            this.cmsRepository.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRepository
            // 
            this.dgvRepository.AllowUserToAddRows = false;
            this.dgvRepository.AllowUserToDeleteRows = false;
            this.dgvRepository.AllowUserToOrderColumns = true;
            this.dgvRepository.AllowUserToResizeColumns = false;
            this.dgvRepository.AllowUserToResizeRows = false;
            this.dgvRepository.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvRepository.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepository.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNumber,
            this.ColDateTime,
            this.ColImage,
            this.ColPath,
            this.ColHash});
            this.dgvRepository.Location = new System.Drawing.Point(13, 41);
            this.dgvRepository.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvRepository.MultiSelect = false;
            this.dgvRepository.Name = "dgvRepository";
            this.dgvRepository.ReadOnly = true;
            this.dgvRepository.RowHeadersVisible = false;
            this.dgvRepository.RowTemplate.Height = 50;
            this.dgvRepository.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepository.Size = new System.Drawing.Size(305, 583);
            this.dgvRepository.TabIndex = 12;
            this.dgvRepository.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRepository_CellDoubleClick);
            this.dgvRepository.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvRepository_CellMouseClick);
            this.dgvRepository.SelectionChanged += new System.EventHandler(this.DgvRepository_SelectionChanged);
            this.dgvRepository.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvRepository_KeyDown);
            // 
            // ColNumber
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColNumber.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColNumber.HeaderText = "No.";
            this.ColNumber.Name = "ColNumber";
            this.ColNumber.ReadOnly = true;
            this.ColNumber.Width = 40;
            // 
            // ColDateTime
            // 
            dataGridViewCellStyle2.Format = "yyyy/MM/dd HH:mm:ss";
            dataGridViewCellStyle2.NullValue = null;
            this.ColDateTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColDateTime.HeaderText = "日付時刻";
            this.ColDateTime.Name = "ColDateTime";
            this.ColDateTime.ReadOnly = true;
            this.ColDateTime.Width = 145;
            // 
            // ColImage
            // 
            this.ColImage.HeaderText = "画像";
            this.ColImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ColImage.Name = "ColImage";
            this.ColImage.ReadOnly = true;
            // 
            // ColPath
            // 
            this.ColPath.HeaderText = "ファイルパス";
            this.ColPath.Name = "ColPath";
            this.ColPath.ReadOnly = true;
            this.ColPath.Visible = false;
            // 
            // ColHash
            // 
            this.ColHash.HeaderText = "ハッシュ値";
            this.ColHash.Name = "ColHash";
            this.ColHash.ReadOnly = true;
            this.ColHash.Visible = false;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(218, 16);
            this.lblInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(40, 14);
            this.lblInformation.TabIndex = 4;
            this.lblInformation.Text = "※情報";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(408, 16);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(333, 14);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "※明細ダブルクリック、もしくはEnter押下でクリップボードにコピーします";
            // 
            // llOpenSaveDir
            // 
            this.llOpenSaveDir.AutoSize = true;
            this.llOpenSaveDir.Location = new System.Drawing.Point(118, 16);
            this.llOpenSaveDir.Name = "llOpenSaveDir";
            this.llOpenSaveDir.Size = new System.Drawing.Size(93, 14);
            this.llOpenSaveDir.TabIndex = 11;
            this.llOpenSaveDir.TabStop = true;
            this.llOpenSaveDir.Text = "保存フォルダを開く";
            this.llOpenSaveDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlOpenSaveDir_LinkClicked);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(12, 12);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(100, 23);
            this.btnExportExcel.TabIndex = 10;
            this.btnExportExcel.Text = "Excel出力";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.BtnExportExcel_Click);
            // 
            // cmsRepository
            // 
            this.cmsRepository.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiDelete});
            this.cmsRepository.Name = "cmsRepository";
            this.cmsRepository.Size = new System.Drawing.Size(99, 26);
            // 
            // tmsiDelete
            // 
            this.tmsiDelete.ForeColor = System.Drawing.Color.Red;
            this.tmsiDelete.Name = "tmsiDelete";
            this.tmsiDelete.Size = new System.Drawing.Size(98, 22);
            this.tmsiDelete.Text = "削除";
            this.tmsiDelete.Click += new System.EventHandler(this.TmsiDelete_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetting.Location = new System.Drawing.Point(1097, 12);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(75, 23);
            this.btnSetting.TabIndex = 21;
            this.btnSetting.Text = "設定";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(326, 41);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(845, 583);
            this.pictureBox.TabIndex = 22;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(326, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "編集";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.llOpenSaveDir);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.dgvRepository);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clippy";
            this.Activated += new System.EventHandler(this.ViewerForm_Activated);
            this.Shown += new System.EventHandler(this.ViewerForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ViewerForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepository)).EndInit();
            this.cmsRepository.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRepository;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.LinkLabel llOpenSaveDir;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.ContextMenuStrip cmsRepository;
        private System.Windows.Forms.ToolStripMenuItem tmsiDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDateTime;
        private System.Windows.Forms.DataGridViewImageColumn ColImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHash;
        private System.Windows.Forms.Button btnSetting;
        private MyPictureBox pictureBox;
        private System.Windows.Forms.Button btnEdit;
    }
}

