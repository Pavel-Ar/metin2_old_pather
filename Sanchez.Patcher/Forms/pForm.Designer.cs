namespace Sanchez.Patcher
{
    partial class pForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pForm));
            this.completeProgress = new System.Windows.Forms.ProgressBar();
            this.currentProgress = new System.Windows.Forms.ProgressBar();
            this.completeProgressText = new System.Windows.Forms.Label();
            this.currentProgressText = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.Status = new System.Windows.Forms.Label();
            this.WebBrowserNews = new System.Windows.Forms.WebBrowser();
            this.Close = new System.Windows.Forms.Button();
            this.Config = new System.Windows.Forms.Button();
            this.AccountSetup = new System.Windows.Forms.Button();
            this.NewAccount = new System.Windows.Forms.Button();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // completeProgress
            // 
            this.completeProgress.Location = new System.Drawing.Point(12, 12);
            this.completeProgress.Name = "completeProgress";
            this.completeProgress.Size = new System.Drawing.Size(576, 21);
            this.completeProgress.TabIndex = 1;
            // 
            // currentProgress
            // 
            this.currentProgress.Location = new System.Drawing.Point(12, 12);
            this.currentProgress.Name = "currentProgress";
            this.currentProgress.Size = new System.Drawing.Size(576, 21);
            this.currentProgress.TabIndex = 2;
            this.currentProgress.Visible = false;
            // 
            // completeProgressText
            // 
            this.completeProgressText.AutoSize = true;
            this.completeProgressText.BackColor = System.Drawing.Color.Transparent;
            this.completeProgressText.ForeColor = System.Drawing.Color.White;
            this.completeProgressText.Location = new System.Drawing.Point(494, 38);
            this.completeProgressText.Name = "completeProgressText";
            this.completeProgressText.Size = new System.Drawing.Size(86, 13);
            this.completeProgressText.TabIndex = 3;
            this.completeProgressText.Text = "Загрузка: 0%";
            // 
            // currentProgressText
            // 
            this.currentProgressText.AutoSize = true;
            this.currentProgressText.BackColor = System.Drawing.Color.Transparent;
            this.currentProgressText.ForeColor = System.Drawing.Color.White;
            this.currentProgressText.Location = new System.Drawing.Point(187, 38);
            this.currentProgressText.Name = "currentProgressText";
            this.currentProgressText.Size = new System.Drawing.Size(162, 13);
            this.currentProgressText.TabIndex = 4;
            this.currentProgressText.Text = "Загрузка файла: 0%  |  0.00 kb/s";
            this.currentProgressText.Visible = false;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.BackgroundImage = global::Sanchez.Patcher.Properties.Resources.btn_startgame_dn;
            this.Start.Enabled = false;
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.ForeColor = System.Drawing.Color.Transparent;
            this.Start.Location = new System.Drawing.Point(467, 46);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(123, 37);
            this.Start.TabIndex = 5;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            this.Start.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Start_MouseDown);
            this.Start.MouseEnter += new System.EventHandler(this.Start_MouseEnter);
            this.Start.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            this.Start.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Start_MouseUp);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackgroundImage = global::Sanchez.Patcher.Properties.Resources.bg;
            this.BottomPanel.Controls.Add(this.Status);
            this.BottomPanel.Controls.Add(this.currentProgress);
            this.BottomPanel.Controls.Add(this.completeProgress);
            this.BottomPanel.Controls.Add(this.currentProgressText);
            this.BottomPanel.Controls.Add(this.completeProgressText);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 399);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(600, 61);
            this.BottomPanel.TabIndex = 6;
            this.BottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseDown);
            this.BottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseMove);
            this.BottomPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseUp);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.Color.Transparent;
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.Location = new System.Drawing.Point(9, 38);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 7;
            this.Status.Text = "Статус";
            // 
            // WebBrowserNews
            // 
            this.WebBrowserNews.IsWebBrowserContextMenuEnabled = false;
            this.WebBrowserNews.Location = new System.Drawing.Point(12, 11);
            this.WebBrowserNews.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowserNews.Name = "WebBrowserNews";
            this.WebBrowserNews.ScrollBarsEnabled = false;
            this.WebBrowserNews.Size = new System.Drawing.Size(446, 374);
            this.WebBrowserNews.TabIndex = 7;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImage = global::Sanchez.Patcher.Properties.Resources.btn_quit_up;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(467, 363);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(123, 22);
            this.Close.TabIndex = 8;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Close_MouseDown);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.Close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Close_MouseUp);
            // 
            // Config
            // 
            this.Config.BackColor = System.Drawing.Color.Transparent;
            this.Config.BackgroundImage = global::Sanchez.Patcher.Properties.Resources.btn_settings_dn;
            this.Config.Enabled = false;
            this.Config.FlatAppearance.BorderSize = 0;
            this.Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Config.Location = new System.Drawing.Point(467, 103);
            this.Config.Name = "Config";
            this.Config.Size = new System.Drawing.Size(123, 22);
            this.Config.TabIndex = 9;
            this.Config.UseVisualStyleBackColor = false;
            this.Config.Click += new System.EventHandler(this.Config_Click);
            this.Config.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Config_MouseDown);
            this.Config.MouseEnter += new System.EventHandler(this.Config_MouseEnter);
            this.Config.MouseLeave += new System.EventHandler(this.Config_MouseLeave);
            this.Config.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Config_MouseUp);
            // 
            // AccountSetup
            // 
            this.AccountSetup.BackColor = System.Drawing.Color.Transparent;
            this.AccountSetup.BackgroundImage = global::Sanchez.Patcher.Properties.Resources.btn_idpwd_up;
            this.AccountSetup.FlatAppearance.BorderSize = 0;
            this.AccountSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountSetup.Location = new System.Drawing.Point(467, 166);
            this.AccountSetup.Name = "AccountSetup";
            this.AccountSetup.Size = new System.Drawing.Size(123, 22);
            this.AccountSetup.TabIndex = 10;
            this.AccountSetup.UseVisualStyleBackColor = false;
            this.AccountSetup.Click += new System.EventHandler(this.AccountSetup_Click);
            this.AccountSetup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AccountSetup_MouseDown);
            this.AccountSetup.MouseEnter += new System.EventHandler(this.AccountSetup_MouseEnter);
            this.AccountSetup.MouseLeave += new System.EventHandler(this.AccountSetup_MouseLeave);
            this.AccountSetup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AccountSetup_MouseUp);
            // 
            // NewAccount
            // 
            this.NewAccount.BackColor = System.Drawing.Color.Transparent;
            this.NewAccount.BackgroundImage = global::Sanchez.Patcher.Properties.Resources.btn_newaccount_up;
            this.NewAccount.FlatAppearance.BorderSize = 0;
            this.NewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewAccount.Location = new System.Drawing.Point(467, 194);
            this.NewAccount.Name = "NewAccount";
            this.NewAccount.Size = new System.Drawing.Size(123, 22);
            this.NewAccount.TabIndex = 11;
            this.NewAccount.UseVisualStyleBackColor = false;
            this.NewAccount.Click += new System.EventHandler(this.NewAccount_Click);
            this.NewAccount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewAccount_MouseDown);
            this.NewAccount.MouseEnter += new System.EventHandler(this.NewAccount_MouseEnter);
            this.NewAccount.MouseLeave += new System.EventHandler(this.NewAccount_MouseLeave);
            this.NewAccount.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NewAccount_MouseUp);
            // 
            // pForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Sanchez.Patcher.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 460);
            this.Controls.Add(this.NewAccount);
            this.Controls.Add(this.AccountSetup);
            this.Controls.Add(this.Config);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.WebBrowserNews);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "pForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patcher";
            this.Shown += new System.EventHandler(this.pForm_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pForm_MouseUp);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public  System.Windows.Forms.ProgressBar completeProgress;
        public  System.Windows.Forms.ProgressBar currentProgress;
        public  System.Windows.Forms.Label completeProgressText;
        public  System.Windows.Forms.Label currentProgressText;
        public  System.Windows.Forms.Button Start;
        public System.Windows.Forms.Panel BottomPanel;
        public System.Windows.Forms.Label Status;
        public System.Windows.Forms.WebBrowser WebBrowserNews;
        public System.Windows.Forms.Button Close;
        public System.Windows.Forms.Button Config;
        public System.Windows.Forms.Button AccountSetup;
        public System.Windows.Forms.Button NewAccount;
    }
}

