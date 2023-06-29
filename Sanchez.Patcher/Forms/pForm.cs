using Sanchez.Patcher.Source_files;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Sanchez.Patcher
{
    public partial class pForm : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public pForm()
        {
            InitializeComponent();

            Globals.pForm = this;

            WebBrowserNews.Navigate(Globals.PatchNewsURL);
        }

        private void pForm_Shown(object sender, EventArgs e)
        {
            if (Common.IsGameRunning())
            {
                Common.EnableStart();
            }
            else
            {
                Networking.CheckNetwork();
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Starter.Start();
        }

        private void Config_Click(object sender, EventArgs e)
        {
            Starter.Config();
        }

        private void AccountSetup_Click(object sender, EventArgs e)
        {
            Process.Start(Globals.AccountURL);
        }

        private void NewAccount_Click(object sender, EventArgs e)
        {
            Process.Start(Globals.RegisterURL);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pForm_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void pForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point diff = new Point(Cursor.Position.X - lastCursor.X, Cursor.Position.Y - lastCursor.Y);
                this.Location = new Point(lastForm.X + diff.X, lastForm.Y + diff.Y);
            }
        }

        private void BottomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void BottomPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point diff = new Point(Cursor.Position.X - lastCursor.X, Cursor.Position.Y - lastCursor.Y);
                this.Location = new Point(lastForm.X + diff.X, lastForm.Y + diff.Y);
            }
        }

        private void BottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void Start_MouseDown(object sender, MouseEventArgs e)
        {
            Start.BackgroundImage = Properties.Resources.btn_startgame_dn;
        }

        private void Start_MouseEnter(object sender, EventArgs e)
        {
            Start.BackgroundImage = Properties.Resources.btn_startgame_fs;
        }

        private void Start_MouseLeave(object sender, EventArgs e)
        {
            Start.BackgroundImage = Properties.Resources.btn_startgame_up;
        }

        private void Start_MouseUp(object sender, MouseEventArgs e)
        {
            Start.BackgroundImage = Properties.Resources.btn_startgame_up;
        }

        private void Close_MouseDown(object sender, MouseEventArgs e)
        {
            Close.BackgroundImage = Properties.Resources.btn_quit_dn;
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.BackgroundImage = Properties.Resources.btn_quit_fs;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.BackgroundImage = Properties.Resources.btn_quit_up;
        }

        private void Close_MouseUp(object sender, MouseEventArgs e)
        {
            Close.BackgroundImage = Properties.Resources.btn_quit_up;
        }

        private void Config_MouseDown(object sender, MouseEventArgs e)
        {
            Config.BackgroundImage = Properties.Resources.btn_settings_dn;
        }

        private void Config_MouseEnter(object sender, EventArgs e)
        {
            Config.BackgroundImage = Properties.Resources.btn_settings_fs;
        }

        private void Config_MouseLeave(object sender, EventArgs e)
        {
            Config.BackgroundImage = Properties.Resources.btn_settings_up;
        }

        private void Config_MouseUp(object sender, MouseEventArgs e)
        {
            Config.BackgroundImage = Properties.Resources.btn_settings_up;
        }

        private void AccountSetup_MouseDown(object sender, MouseEventArgs e)
        {
            AccountSetup.BackgroundImage = Properties.Resources.btn_idpwd_dn;
        }

        private void AccountSetup_MouseEnter(object sender, EventArgs e)
        {
            AccountSetup.BackgroundImage = Properties.Resources.btn_idpwd_fs;
        }

        private void AccountSetup_MouseLeave(object sender, EventArgs e)
        {
            AccountSetup.BackgroundImage = Properties.Resources.btn_idpwd_up;
        }

        private void AccountSetup_MouseUp(object sender, MouseEventArgs e)
        {
            AccountSetup.BackgroundImage = Properties.Resources.btn_idpwd_up;
        }

        private void NewAccount_MouseDown(object sender, MouseEventArgs e)
        {
            NewAccount.BackgroundImage = Properties.Resources.btn_newaccount_dn;
        }

        private void NewAccount_MouseEnter(object sender, EventArgs e)
        {
            NewAccount.BackgroundImage = Properties.Resources.btn_newaccount_fs;
        }

        private void NewAccount_MouseLeave(object sender, EventArgs e)
        {
            NewAccount.BackgroundImage = Properties.Resources.btn_newaccount_up;
        }

        private void NewAccount_MouseUp(object sender, MouseEventArgs e)
        {
            NewAccount.BackgroundImage = Properties.Resources.btn_newaccount_up;
        }
    }
}
