namespace Clippy
{
    partial class RegidentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegidentForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiOpenViewer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOpenSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOpenDeployFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Clippy";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenViewer,
            this.toolStripSeparator1,
            this.tsmiOpenSetting,
            this.toolStripSeparator2,
            this.tsmiOpenDeployFolder,
            this.tsmiRestart,
            this.tsmiExitApp});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(198, 148);
            // 
            // tsmiOpenViewer
            // 
            this.tsmiOpenViewer.Name = "tsmiOpenViewer";
            this.tsmiOpenViewer.Size = new System.Drawing.Size(197, 22);
            this.tsmiOpenViewer.Text = "メイン画面 を開く";
            this.tsmiOpenViewer.Click += new System.EventHandler(this.TsmiOpenViewer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // tsmiOpenSetting
            // 
            this.tsmiOpenSetting.Name = "tsmiOpenSetting";
            this.tsmiOpenSetting.Size = new System.Drawing.Size(197, 22);
            this.tsmiOpenSetting.Text = "設定";
            this.tsmiOpenSetting.Click += new System.EventHandler(this.TsmiOpenSetting_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
            // 
            // tsmiOpenDeployFolder
            // 
            this.tsmiOpenDeployFolder.Name = "tsmiOpenDeployFolder";
            this.tsmiOpenDeployFolder.Size = new System.Drawing.Size(197, 22);
            this.tsmiOpenDeployFolder.Text = "Clippy 配置フォルダを開く";
            this.tsmiOpenDeployFolder.Click += new System.EventHandler(this.TsmiOpenDeployFolder_Click);
            // 
            // tsmiRestart
            // 
            this.tsmiRestart.Name = "tsmiRestart";
            this.tsmiRestart.Size = new System.Drawing.Size(197, 22);
            this.tsmiRestart.Text = "Clippy を再起動する";
            this.tsmiRestart.Click += new System.EventHandler(this.TsmiRestart_Click);
            // 
            // tsmiExitApp
            // 
            this.tsmiExitApp.Name = "tsmiExitApp";
            this.tsmiExitApp.Size = new System.Drawing.Size(197, 22);
            this.tsmiExitApp.Text = "Clippy を終了する";
            this.tsmiExitApp.Click += new System.EventHandler(this.TsmiExitApp_Click);
            // 
            // RegidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 47);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RegidentForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clippy";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenViewer;
        private System.Windows.Forms.ToolStripMenuItem tsmiExitApp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiRestart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenDeployFolder;
    }
}