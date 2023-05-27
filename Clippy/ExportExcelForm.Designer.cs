namespace Clippy
{
    partial class ExportExcelForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportExcelForm));
            this.dgvRepository = new System.Windows.Forms.DataGridView();
            this.ColSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColTrim = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpFilterFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpFilterTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTrimAll = new System.Windows.Forms.Button();
            this.pictureBox = new Clippy.MyPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepository)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRepository
            // 
            this.dgvRepository.AllowDrop = true;
            this.dgvRepository.AllowUserToAddRows = false;
            this.dgvRepository.AllowUserToDeleteRows = false;
            this.dgvRepository.AllowUserToOrderColumns = true;
            this.dgvRepository.AllowUserToResizeColumns = false;
            this.dgvRepository.AllowUserToResizeRows = false;
            this.dgvRepository.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvRepository.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepository.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSelect,
            this.ColTrim,
            this.ColDateTime,
            this.ColImage,
            this.ColPath});
            this.dgvRepository.Location = new System.Drawing.Point(13, 71);
            this.dgvRepository.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRepository.MultiSelect = false;
            this.dgvRepository.Name = "dgvRepository";
            this.dgvRepository.RowHeadersVisible = false;
            this.dgvRepository.RowTemplate.Height = 50;
            this.dgvRepository.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepository.Size = new System.Drawing.Size(345, 523);
            this.dgvRepository.TabIndex = 30;
            this.dgvRepository.SelectionChanged += new System.EventHandler(this.DgvRepository_SelectionChanged);
            this.dgvRepository.DragDrop += new System.Windows.Forms.DragEventHandler(this.DgvRepository_DragDrop);
            this.dgvRepository.DragOver += new System.Windows.Forms.DragEventHandler(this.DgvRepository_DragOver);
            this.dgvRepository.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DgvRepository_MouseDown);
            this.dgvRepository.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DgvRepository_MouseMove);
            // 
            // ColSelect
            // 
            this.ColSelect.HeaderText = "選択";
            this.ColSelect.Name = "ColSelect";
            this.ColSelect.Width = 40;
            // 
            // ColTrim
            // 
            this.ColTrim.HeaderText = "切取";
            this.ColTrim.Name = "ColTrim";
            this.ColTrim.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColTrim.Width = 40;
            // 
            // ColDateTime
            // 
            dataGridViewCellStyle1.Format = "yyyy/MM/dd HH:mm:ss";
            this.ColDateTime.DefaultCellStyle = dataGridViewCellStyle1;
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
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.Location = new System.Drawing.Point(965, 601);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(100, 23);
            this.btnExportExcel.TabIndex = 40;
            this.btnExportExcel.Text = "出力実行";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.BtnExportExcel_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(12, 41);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(100, 23);
            this.btnSelectAll.TabIndex = 20;
            this.btnSelectAll.Text = "全選択/解除";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.BtnSelectAll_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(456, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 23);
            this.btnFilter.TabIndex = 13;
            this.btnFilter.Text = "フィルタ適用";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // dtpFilterFrom
            // 
            this.dtpFilterFrom.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dtpFilterFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFilterFrom.Location = new System.Drawing.Point(79, 12);
            this.dtpFilterFrom.Name = "dtpFilterFrom";
            this.dtpFilterFrom.ShowCheckBox = true;
            this.dtpFilterFrom.Size = new System.Drawing.Size(170, 22);
            this.dtpFilterFrom.TabIndex = 11;
            // 
            // dtpFilterTo
            // 
            this.dtpFilterTo.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dtpFilterTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFilterTo.Location = new System.Drawing.Point(280, 12);
            this.dtpFilterTo.Name = "dtpFilterTo";
            this.dtpFilterTo.ShowCheckBox = true;
            this.dtpFilterTo.Size = new System.Drawing.Size(170, 22);
            this.dtpFilterTo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "～";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 31;
            this.label2.Text = "日付時刻：";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1071, 601);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnTrimAll
            // 
            this.btnTrimAll.Location = new System.Drawing.Point(118, 40);
            this.btnTrimAll.Name = "btnTrimAll";
            this.btnTrimAll.Size = new System.Drawing.Size(100, 23);
            this.btnTrimAll.TabIndex = 21;
            this.btnTrimAll.Text = "全切取/解除";
            this.btnTrimAll.UseVisualStyleBackColor = true;
            this.btnTrimAll.Click += new System.EventHandler(this.BtnTrimAll_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(367, 71);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(804, 523);
            this.pictureBox.TabIndex = 42;
            // 
            // ExportExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnTrimAll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRepository);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFilterTo);
            this.Controls.Add(this.dtpFilterFrom);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnExportExcel);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExportExcelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clippy - Excel出力";
            this.Load += new System.EventHandler(this.ExportExcelForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExportExcelForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepository)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRepository;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtpFilterFrom;
        private System.Windows.Forms.DateTimePicker dtpFilterTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSelect;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColTrim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDateTime;
        private System.Windows.Forms.DataGridViewImageColumn ColImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPath;
        private System.Windows.Forms.Button btnTrimAll;
        private MyPictureBox pictureBox;
    }
}