namespace Clippy
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.chkSkipStartWindow = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.llOpenShellStartup = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // chkSkipStartWindow
            // 
            this.chkSkipStartWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSkipStartWindow.AutoSize = true;
            this.chkSkipStartWindow.Location = new System.Drawing.Point(13, 326);
            this.chkSkipStartWindow.Margin = new System.Windows.Forms.Padding(4);
            this.chkSkipStartWindow.Name = "chkSkipStartWindow";
            this.chkSkipStartWindow.Size = new System.Drawing.Size(135, 18);
            this.chkSkipStartWindow.TabIndex = 6;
            this.chkSkipStartWindow.Text = "次回以降、表示しない";
            this.chkSkipStartWindow.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(383, 321);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 27);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(14, 14);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(456, 298);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.TabStop = false;
            this.txtDescription.Text = resources.GetString("txtDescription.Text");
            // 
            // llOpenShellStartup
            // 
            this.llOpenShellStartup.AutoSize = true;
            this.llOpenShellStartup.BackColor = System.Drawing.Color.Transparent;
            this.llOpenShellStartup.Location = new System.Drawing.Point(54, 240);
            this.llOpenShellStartup.Name = "llOpenShellStartup";
            this.llOpenShellStartup.Size = new System.Drawing.Size(98, 14);
            this.llOpenShellStartup.TabIndex = 7;
            this.llOpenShellStartup.TabStop = true;
            this.llOpenShellStartup.Text = "shell:startup";
            this.llOpenShellStartup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlOpenShellStartup_LinkClicked);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.llOpenShellStartup);
            this.Controls.Add(this.chkSkipStartWindow);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDescription);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clippy へようこそ！";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSkipStartWindow;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.LinkLabel llOpenShellStartup;
    }
}