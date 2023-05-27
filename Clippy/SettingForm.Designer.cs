namespace Clippy
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPictureSaveFolderPath = new System.Windows.Forms.Label();
            this.txtPictureSaveFolderPath = new System.Windows.Forms.TextBox();
            this.btnSearchPictureSaveFolderPath = new System.Windows.Forms.Button();
            this.gbHotKey = new System.Windows.Forms.GroupBox();
            this.pnlCustomHotKey = new System.Windows.Forms.Panel();
            this.txtCustomHotKey = new System.Windows.Forms.TextBox();
            this.lblCustomModKey = new System.Windows.Forms.Label();
            this.lblCustomKey = new System.Windows.Forms.Label();
            this.chkCtrl = new System.Windows.Forms.CheckBox();
            this.chkAlt = new System.Windows.Forms.CheckBox();
            this.chkShift = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudDoubleHotKeyTimeSpan = new System.Windows.Forms.NumericUpDown();
            this.rdoHotKey_Custom = new System.Windows.Forms.RadioButton();
            this.rdoHotKey_DoubleAlt = new System.Windows.Forms.RadioButton();
            this.rdoHotKey_DoubleShift = new System.Windows.Forms.RadioButton();
            this.rdoHotKey_DoubleCtrl = new System.Windows.Forms.RadioButton();
            this.rdoHotKey_None = new System.Windows.Forms.RadioButton();
            this.chkSkipStartWindow = new System.Windows.Forms.CheckBox();
            this.gbAutoDelete = new System.Windows.Forms.GroupBox();
            this.lblAutoDeleteInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudSavePictureTimeSpan = new System.Windows.Forms.NumericUpDown();
            this.rdoAutoDelete_Yes = new System.Windows.Forms.RadioButton();
            this.rdoAutoDelete_No = new System.Windows.Forms.RadioButton();
            this.gbExcelExport = new System.Windows.Forms.GroupBox();
            this.rdoSilver = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoBlack = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudBorderWidth = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudTrimRight = new System.Windows.Forms.NumericUpDown();
            this.nudTrimLeft = new System.Windows.Forms.NumericUpDown();
            this.nudTrimBottom = new System.Windows.Forms.NumericUpDown();
            this.nudTrimTop = new System.Windows.Forms.NumericUpDown();
            this.gbHotKey.SuspendLayout();
            this.pnlCustomHotKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoubleHotKeyTimeSpan)).BeginInit();
            this.gbAutoDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSavePictureTimeSpan)).BeginInit();
            this.gbExcelExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrimRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrimLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrimBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrimTop)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(281, 532);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 27);
            this.btnSave.TabIndex = 1001;
            this.btnSave.Text = "保存する";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(377, 532);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 27);
            this.btnCancel.TabIndex = 1002;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblPictureSaveFolderPath
            // 
            this.lblPictureSaveFolderPath.AutoSize = true;
            this.lblPictureSaveFolderPath.Location = new System.Drawing.Point(13, 9);
            this.lblPictureSaveFolderPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPictureSaveFolderPath.Name = "lblPictureSaveFolderPath";
            this.lblPictureSaveFolderPath.Size = new System.Drawing.Size(130, 14);
            this.lblPictureSaveFolderPath.TabIndex = 2;
            this.lblPictureSaveFolderPath.Text = "画像ファイル保存フォルダ：";
            // 
            // txtPictureSaveFolderPath
            // 
            this.txtPictureSaveFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPictureSaveFolderPath.Location = new System.Drawing.Point(13, 27);
            this.txtPictureSaveFolderPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtPictureSaveFolderPath.Name = "txtPictureSaveFolderPath";
            this.txtPictureSaveFolderPath.Size = new System.Drawing.Size(412, 22);
            this.txtPictureSaveFolderPath.TabIndex = 200;
            // 
            // btnSearchPictureSaveFolderPath
            // 
            this.btnSearchPictureSaveFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchPictureSaveFolderPath.Location = new System.Drawing.Point(433, 26);
            this.btnSearchPictureSaveFolderPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchPictureSaveFolderPath.Name = "btnSearchPictureSaveFolderPath";
            this.btnSearchPictureSaveFolderPath.Size = new System.Drawing.Size(32, 24);
            this.btnSearchPictureSaveFolderPath.TabIndex = 201;
            this.btnSearchPictureSaveFolderPath.Text = "…";
            this.btnSearchPictureSaveFolderPath.UseVisualStyleBackColor = true;
            this.btnSearchPictureSaveFolderPath.Click += new System.EventHandler(this.BtnSearchPictureSaveFolderPath_Click);
            // 
            // gbHotKey
            // 
            this.gbHotKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHotKey.Controls.Add(this.pnlCustomHotKey);
            this.gbHotKey.Controls.Add(this.label2);
            this.gbHotKey.Controls.Add(this.label1);
            this.gbHotKey.Controls.Add(this.nudDoubleHotKeyTimeSpan);
            this.gbHotKey.Controls.Add(this.rdoHotKey_Custom);
            this.gbHotKey.Controls.Add(this.rdoHotKey_DoubleAlt);
            this.gbHotKey.Controls.Add(this.rdoHotKey_DoubleShift);
            this.gbHotKey.Controls.Add(this.rdoHotKey_DoubleCtrl);
            this.gbHotKey.Controls.Add(this.rdoHotKey_None);
            this.gbHotKey.Location = new System.Drawing.Point(12, 57);
            this.gbHotKey.Name = "gbHotKey";
            this.gbHotKey.Size = new System.Drawing.Size(454, 234);
            this.gbHotKey.TabIndex = 300;
            this.gbHotKey.TabStop = false;
            this.gbHotKey.Text = "ホットキー設定";
            // 
            // pnlCustomHotKey
            // 
            this.pnlCustomHotKey.Controls.Add(this.txtCustomHotKey);
            this.pnlCustomHotKey.Controls.Add(this.lblCustomModKey);
            this.pnlCustomHotKey.Controls.Add(this.lblCustomKey);
            this.pnlCustomHotKey.Controls.Add(this.chkCtrl);
            this.pnlCustomHotKey.Controls.Add(this.chkAlt);
            this.pnlCustomHotKey.Controls.Add(this.chkShift);
            this.pnlCustomHotKey.Location = new System.Drawing.Point(25, 141);
            this.pnlCustomHotKey.Name = "pnlCustomHotKey";
            this.pnlCustomHotKey.Size = new System.Drawing.Size(282, 56);
            this.pnlCustomHotKey.TabIndex = 6;
            // 
            // txtCustomHotKey
            // 
            this.txtCustomHotKey.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtCustomHotKey.Location = new System.Drawing.Point(46, 27);
            this.txtCustomHotKey.MaxLength = 1;
            this.txtCustomHotKey.Name = "txtCustomHotKey";
            this.txtCustomHotKey.Size = new System.Drawing.Size(100, 22);
            this.txtCustomHotKey.TabIndex = 4;
            this.txtCustomHotKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCustomHotKey_KeyDown);
            // 
            // lblCustomModKey
            // 
            this.lblCustomModKey.AutoSize = true;
            this.lblCustomModKey.Location = new System.Drawing.Point(3, 4);
            this.lblCustomModKey.Name = "lblCustomModKey";
            this.lblCustomModKey.Size = new System.Drawing.Size(37, 14);
            this.lblCustomModKey.TabIndex = 12;
            this.lblCustomModKey.Text = "修飾：";
            // 
            // lblCustomKey
            // 
            this.lblCustomKey.AutoSize = true;
            this.lblCustomKey.Location = new System.Drawing.Point(7, 30);
            this.lblCustomKey.Name = "lblCustomKey";
            this.lblCustomKey.Size = new System.Drawing.Size(33, 14);
            this.lblCustomKey.TabIndex = 13;
            this.lblCustomKey.Text = "キー：";
            // 
            // chkCtrl
            // 
            this.chkCtrl.AutoSize = true;
            this.chkCtrl.Location = new System.Drawing.Point(46, 3);
            this.chkCtrl.Name = "chkCtrl";
            this.chkCtrl.Size = new System.Drawing.Size(54, 18);
            this.chkCtrl.TabIndex = 1;
            this.chkCtrl.Text = "Ctrl";
            this.chkCtrl.UseVisualStyleBackColor = true;
            // 
            // chkAlt
            // 
            this.chkAlt.AutoSize = true;
            this.chkAlt.Location = new System.Drawing.Point(173, 3);
            this.chkAlt.Name = "chkAlt";
            this.chkAlt.Size = new System.Drawing.Size(47, 18);
            this.chkAlt.TabIndex = 3;
            this.chkAlt.Text = "Alt";
            this.chkAlt.UseVisualStyleBackColor = true;
            // 
            // chkShift
            // 
            this.chkShift.AutoSize = true;
            this.chkShift.Location = new System.Drawing.Point(106, 3);
            this.chkShift.Name = "chkShift";
            this.chkShift.Size = new System.Drawing.Size(61, 18);
            this.chkShift.TabIndex = 2;
            this.chkShift.Text = "Shift";
            this.chkShift.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "ミリ秒";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "2回押下設定時の間隔：";
            // 
            // nudDoubleHotKeyTimeSpan
            // 
            this.nudDoubleHotKeyTimeSpan.Location = new System.Drawing.Point(135, 203);
            this.nudDoubleHotKeyTimeSpan.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudDoubleHotKeyTimeSpan.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudDoubleHotKeyTimeSpan.Name = "nudDoubleHotKeyTimeSpan";
            this.nudDoubleHotKeyTimeSpan.Size = new System.Drawing.Size(50, 22);
            this.nudDoubleHotKeyTimeSpan.TabIndex = 7;
            this.nudDoubleHotKeyTimeSpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDoubleHotKeyTimeSpan.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // rdoHotKey_Custom
            // 
            this.rdoHotKey_Custom.AutoSize = true;
            this.rdoHotKey_Custom.Location = new System.Drawing.Point(6, 117);
            this.rdoHotKey_Custom.Name = "rdoHotKey_Custom";
            this.rdoHotKey_Custom.Size = new System.Drawing.Size(85, 18);
            this.rdoHotKey_Custom.TabIndex = 5;
            this.rdoHotKey_Custom.TabStop = true;
            this.rdoHotKey_Custom.Text = "カスタム設定";
            this.rdoHotKey_Custom.UseVisualStyleBackColor = true;
            this.rdoHotKey_Custom.CheckedChanged += new System.EventHandler(this.RdoHotKey_CheckedChanged);
            // 
            // rdoHotKey_DoubleAlt
            // 
            this.rdoHotKey_DoubleAlt.AutoSize = true;
            this.rdoHotKey_DoubleAlt.Location = new System.Drawing.Point(6, 93);
            this.rdoHotKey_DoubleAlt.Name = "rdoHotKey_DoubleAlt";
            this.rdoHotKey_DoubleAlt.Size = new System.Drawing.Size(183, 18);
            this.rdoHotKey_DoubleAlt.TabIndex = 4;
            this.rdoHotKey_DoubleAlt.TabStop = true;
            this.rdoHotKey_DoubleAlt.Text = "Altキー   2回押下で呼び出し";
            this.rdoHotKey_DoubleAlt.UseVisualStyleBackColor = true;
            this.rdoHotKey_DoubleAlt.CheckedChanged += new System.EventHandler(this.RdoHotKey_CheckedChanged);
            // 
            // rdoHotKey_DoubleShift
            // 
            this.rdoHotKey_DoubleShift.AutoSize = true;
            this.rdoHotKey_DoubleShift.Location = new System.Drawing.Point(6, 69);
            this.rdoHotKey_DoubleShift.Name = "rdoHotKey_DoubleShift";
            this.rdoHotKey_DoubleShift.Size = new System.Drawing.Size(183, 18);
            this.rdoHotKey_DoubleShift.TabIndex = 3;
            this.rdoHotKey_DoubleShift.TabStop = true;
            this.rdoHotKey_DoubleShift.Text = "Shiftキー 2回押下で呼び出し";
            this.rdoHotKey_DoubleShift.UseVisualStyleBackColor = true;
            this.rdoHotKey_DoubleShift.CheckedChanged += new System.EventHandler(this.RdoHotKey_CheckedChanged);
            // 
            // rdoHotKey_DoubleCtrl
            // 
            this.rdoHotKey_DoubleCtrl.AutoSize = true;
            this.rdoHotKey_DoubleCtrl.Location = new System.Drawing.Point(6, 45);
            this.rdoHotKey_DoubleCtrl.Name = "rdoHotKey_DoubleCtrl";
            this.rdoHotKey_DoubleCtrl.Size = new System.Drawing.Size(183, 18);
            this.rdoHotKey_DoubleCtrl.TabIndex = 2;
            this.rdoHotKey_DoubleCtrl.TabStop = true;
            this.rdoHotKey_DoubleCtrl.Text = "Ctrlキー  2回押下で呼び出し";
            this.rdoHotKey_DoubleCtrl.UseVisualStyleBackColor = true;
            this.rdoHotKey_DoubleCtrl.CheckedChanged += new System.EventHandler(this.RdoHotKey_CheckedChanged);
            // 
            // rdoHotKey_None
            // 
            this.rdoHotKey_None.AutoSize = true;
            this.rdoHotKey_None.Location = new System.Drawing.Point(6, 21);
            this.rdoHotKey_None.Name = "rdoHotKey_None";
            this.rdoHotKey_None.Size = new System.Drawing.Size(78, 18);
            this.rdoHotKey_None.TabIndex = 1;
            this.rdoHotKey_None.TabStop = true;
            this.rdoHotKey_None.Text = "起動しない";
            this.rdoHotKey_None.UseVisualStyleBackColor = true;
            this.rdoHotKey_None.CheckedChanged += new System.EventHandler(this.RdoHotKey_CheckedChanged);
            // 
            // chkSkipStartWindow
            // 
            this.chkSkipStartWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSkipStartWindow.AutoSize = true;
            this.chkSkipStartWindow.Location = new System.Drawing.Point(12, 537);
            this.chkSkipStartWindow.Name = "chkSkipStartWindow";
            this.chkSkipStartWindow.Size = new System.Drawing.Size(259, 18);
            this.chkSkipStartWindow.TabIndex = 1000;
            this.chkSkipStartWindow.Text = "アプリケーション起動時に、スタート画面を省略する";
            this.chkSkipStartWindow.UseVisualStyleBackColor = true;
            // 
            // gbAutoDelete
            // 
            this.gbAutoDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAutoDelete.Controls.Add(this.lblAutoDeleteInfo);
            this.gbAutoDelete.Controls.Add(this.label5);
            this.gbAutoDelete.Controls.Add(this.label6);
            this.gbAutoDelete.Controls.Add(this.nudSavePictureTimeSpan);
            this.gbAutoDelete.Controls.Add(this.rdoAutoDelete_Yes);
            this.gbAutoDelete.Controls.Add(this.rdoAutoDelete_No);
            this.gbAutoDelete.Location = new System.Drawing.Point(12, 297);
            this.gbAutoDelete.Name = "gbAutoDelete";
            this.gbAutoDelete.Size = new System.Drawing.Size(454, 101);
            this.gbAutoDelete.TabIndex = 400;
            this.gbAutoDelete.TabStop = false;
            this.gbAutoDelete.Text = "自動削除設定";
            // 
            // lblAutoDeleteInfo
            // 
            this.lblAutoDeleteInfo.AutoSize = true;
            this.lblAutoDeleteInfo.Location = new System.Drawing.Point(173, 71);
            this.lblAutoDeleteInfo.Name = "lblAutoDeleteInfo";
            this.lblAutoDeleteInfo.Size = new System.Drawing.Size(266, 14);
            this.lblAutoDeleteInfo.TabIndex = 8;
            this.lblAutoDeleteInfo.Text = "(YYYY/MM/DD 00:00 以降のファイルが保存対象)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "日";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "保存期間：";
            // 
            // nudSavePictureTimeSpan
            // 
            this.nudSavePictureTimeSpan.Location = new System.Drawing.Point(90, 69);
            this.nudSavePictureTimeSpan.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudSavePictureTimeSpan.Name = "nudSavePictureTimeSpan";
            this.nudSavePictureTimeSpan.Size = new System.Drawing.Size(50, 22);
            this.nudSavePictureTimeSpan.TabIndex = 3;
            this.nudSavePictureTimeSpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSavePictureTimeSpan.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudSavePictureTimeSpan.ValueChanged += new System.EventHandler(this.NudSavePictureTimeSpan_ValueChanged);
            // 
            // rdoAutoDelete_Yes
            // 
            this.rdoAutoDelete_Yes.AutoSize = true;
            this.rdoAutoDelete_Yes.Location = new System.Drawing.Point(6, 45);
            this.rdoAutoDelete_Yes.Name = "rdoAutoDelete_Yes";
            this.rdoAutoDelete_Yes.Size = new System.Drawing.Size(68, 18);
            this.rdoAutoDelete_Yes.TabIndex = 2;
            this.rdoAutoDelete_Yes.TabStop = true;
            this.rdoAutoDelete_Yes.Text = "削除する";
            this.rdoAutoDelete_Yes.UseVisualStyleBackColor = true;
            // 
            // rdoAutoDelete_No
            // 
            this.rdoAutoDelete_No.AutoSize = true;
            this.rdoAutoDelete_No.Location = new System.Drawing.Point(6, 21);
            this.rdoAutoDelete_No.Name = "rdoAutoDelete_No";
            this.rdoAutoDelete_No.Size = new System.Drawing.Size(78, 18);
            this.rdoAutoDelete_No.TabIndex = 1;
            this.rdoAutoDelete_No.TabStop = true;
            this.rdoAutoDelete_No.Text = "削除しない";
            this.rdoAutoDelete_No.UseVisualStyleBackColor = true;
            this.rdoAutoDelete_No.CheckedChanged += new System.EventHandler(this.RdoAutoDelete_CheckedChanged);
            // 
            // gbExcelExport
            // 
            this.gbExcelExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbExcelExport.Controls.Add(this.rdoSilver);
            this.gbExcelExport.Controls.Add(this.rdoBlue);
            this.gbExcelExport.Controls.Add(this.rdoBlack);
            this.gbExcelExport.Controls.Add(this.label12);
            this.gbExcelExport.Controls.Add(this.label11);
            this.gbExcelExport.Controls.Add(this.nudBorderWidth);
            this.gbExcelExport.Controls.Add(this.label10);
            this.gbExcelExport.Controls.Add(this.label9);
            this.gbExcelExport.Controls.Add(this.label8);
            this.gbExcelExport.Controls.Add(this.label7);
            this.gbExcelExport.Controls.Add(this.label4);
            this.gbExcelExport.Controls.Add(this.label3);
            this.gbExcelExport.Controls.Add(this.nudTrimRight);
            this.gbExcelExport.Controls.Add(this.nudTrimLeft);
            this.gbExcelExport.Controls.Add(this.nudTrimBottom);
            this.gbExcelExport.Controls.Add(this.nudTrimTop);
            this.gbExcelExport.Location = new System.Drawing.Point(12, 404);
            this.gbExcelExport.Name = "gbExcelExport";
            this.gbExcelExport.Size = new System.Drawing.Size(454, 117);
            this.gbExcelExport.TabIndex = 500;
            this.gbExcelExport.TabStop = false;
            this.gbExcelExport.Text = "Excel出力設定";
            // 
            // rdoSilver
            // 
            this.rdoSilver.AutoSize = true;
            this.rdoSilver.BackColor = System.Drawing.Color.Silver;
            this.rdoSilver.Location = new System.Drawing.Point(235, 35);
            this.rdoSilver.Name = "rdoSilver";
            this.rdoSilver.Size = new System.Drawing.Size(37, 18);
            this.rdoSilver.TabIndex = 4;
            this.rdoSilver.TabStop = true;
            this.rdoSilver.Text = "銀";
            this.rdoSilver.UseVisualStyleBackColor = false;
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.BackColor = System.Drawing.Color.DodgerBlue;
            this.rdoBlue.ForeColor = System.Drawing.Color.White;
            this.rdoBlue.Location = new System.Drawing.Point(192, 35);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(37, 18);
            this.rdoBlue.TabIndex = 3;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "青";
            this.rdoBlue.UseVisualStyleBackColor = false;
            // 
            // rdoBlack
            // 
            this.rdoBlack.AutoSize = true;
            this.rdoBlack.BackColor = System.Drawing.Color.Black;
            this.rdoBlack.ForeColor = System.Drawing.Color.White;
            this.rdoBlack.Location = new System.Drawing.Point(149, 35);
            this.rdoBlack.Name = "rdoBlack";
            this.rdoBlack.Size = new System.Drawing.Size(37, 18);
            this.rdoBlack.TabIndex = 2;
            this.rdoBlack.TabStop = true;
            this.rdoBlack.Text = "黒";
            this.rdoBlack.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(118, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 14);
            this.label12.TabIndex = 12;
            this.label12.Text = "色：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 14);
            this.label11.TabIndex = 11;
            this.label11.Text = "幅：";
            // 
            // nudBorderWidth
            // 
            this.nudBorderWidth.Location = new System.Drawing.Point(52, 35);
            this.nudBorderWidth.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudBorderWidth.Name = "nudBorderWidth";
            this.nudBorderWidth.Size = new System.Drawing.Size(60, 22);
            this.nudBorderWidth.TabIndex = 1;
            this.nudBorderWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBorderWidth.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 14);
            this.label10.TabIndex = 9;
            this.label10.Text = "枠線設定：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "右：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "左：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "下：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "上：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "切り取り設定（ピクセル）：";
            // 
            // nudTrimRight
            // 
            this.nudTrimRight.Location = new System.Drawing.Point(344, 84);
            this.nudTrimRight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudTrimRight.Name = "nudTrimRight";
            this.nudTrimRight.Size = new System.Drawing.Size(60, 22);
            this.nudTrimRight.TabIndex = 8;
            this.nudTrimRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTrimRight.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // nudTrimLeft
            // 
            this.nudTrimLeft.Location = new System.Drawing.Point(247, 84);
            this.nudTrimLeft.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudTrimLeft.Name = "nudTrimLeft";
            this.nudTrimLeft.Size = new System.Drawing.Size(60, 22);
            this.nudTrimLeft.TabIndex = 7;
            this.nudTrimLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTrimLeft.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // nudTrimBottom
            // 
            this.nudTrimBottom.Location = new System.Drawing.Point(150, 84);
            this.nudTrimBottom.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudTrimBottom.Name = "nudTrimBottom";
            this.nudTrimBottom.Size = new System.Drawing.Size(60, 22);
            this.nudTrimBottom.TabIndex = 6;
            this.nudTrimBottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTrimBottom.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // nudTrimTop
            // 
            this.nudTrimTop.Location = new System.Drawing.Point(53, 84);
            this.nudTrimTop.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudTrimTop.Name = "nudTrimTop";
            this.nudTrimTop.Size = new System.Drawing.Size(60, 22);
            this.nudTrimTop.TabIndex = 5;
            this.nudTrimTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTrimTop.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 572);
            this.Controls.Add(this.gbExcelExport);
            this.Controls.Add(this.gbAutoDelete);
            this.Controls.Add(this.chkSkipStartWindow);
            this.Controls.Add(this.gbHotKey);
            this.Controls.Add(this.btnSearchPictureSaveFolderPath);
            this.Controls.Add(this.txtPictureSaveFolderPath);
            this.Controls.Add(this.lblPictureSaveFolderPath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clippy - 設定";
            this.gbHotKey.ResumeLayout(false);
            this.gbHotKey.PerformLayout();
            this.pnlCustomHotKey.ResumeLayout(false);
            this.pnlCustomHotKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoubleHotKeyTimeSpan)).EndInit();
            this.gbAutoDelete.ResumeLayout(false);
            this.gbAutoDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSavePictureTimeSpan)).EndInit();
            this.gbExcelExport.ResumeLayout(false);
            this.gbExcelExport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrimRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrimLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrimBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrimTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPictureSaveFolderPath;
        private System.Windows.Forms.TextBox txtPictureSaveFolderPath;
        private System.Windows.Forms.Button btnSearchPictureSaveFolderPath;
        private System.Windows.Forms.GroupBox gbHotKey;
        private System.Windows.Forms.RadioButton rdoHotKey_DoubleCtrl;
        private System.Windows.Forms.RadioButton rdoHotKey_None;
        private System.Windows.Forms.CheckBox chkShift;
        private System.Windows.Forms.CheckBox chkAlt;
        private System.Windows.Forms.CheckBox chkCtrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDoubleHotKeyTimeSpan;
        private System.Windows.Forms.RadioButton rdoHotKey_Custom;
        private System.Windows.Forms.RadioButton rdoHotKey_DoubleAlt;
        private System.Windows.Forms.RadioButton rdoHotKey_DoubleShift;
        private System.Windows.Forms.Label lblCustomKey;
        private System.Windows.Forms.Label lblCustomModKey;
        private System.Windows.Forms.Panel pnlCustomHotKey;
        private System.Windows.Forms.TextBox txtCustomHotKey;
        private System.Windows.Forms.CheckBox chkSkipStartWindow;
        private System.Windows.Forms.GroupBox gbAutoDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudSavePictureTimeSpan;
        private System.Windows.Forms.RadioButton rdoAutoDelete_Yes;
        private System.Windows.Forms.RadioButton rdoAutoDelete_No;
        private System.Windows.Forms.GroupBox gbExcelExport;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudTrimRight;
        private System.Windows.Forms.NumericUpDown nudTrimLeft;
        private System.Windows.Forms.NumericUpDown nudTrimBottom;
        private System.Windows.Forms.NumericUpDown nudTrimTop;
        private System.Windows.Forms.Label lblAutoDeleteInfo;
        private System.Windows.Forms.RadioButton rdoSilver;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.RadioButton rdoBlack;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudBorderWidth;
        private System.Windows.Forms.Label label10;
    }
}