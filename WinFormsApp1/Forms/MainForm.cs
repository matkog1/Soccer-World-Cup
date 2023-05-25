using RazorEngine;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;
using System.Resources;
using WinFormsApp1.Forms;
using System.Globalization;
using RazorEngine.Compilation.ImpromptuInterface.Dynamic;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private const string optionsFile = "options.txt";
        public MainForm()
        {
            InitializeComponent();
            Settings();
            SetLanguage();
        }

        private void Settings()
        {
            pnlLeft.Location = new Point(0, 69);
            pnlLeft.Size = new Size(133, 530);
            pnlLeft.Dock = DockStyle.Left; pnlLeft.TabIndex = 0;
            btnFavorite.Size = new Size(130, 45);
            btnFavorite.Location = new Point(3, 62);
            btnrankingMatches.Location = new Point(3, 124);
            btnPlayerRanking.Location = new Point(3, 185);
            btnSettings.Location = new Point(3, 245);
        }

        private void Reload()
        {
            InitializeComponent();
            SetLanguage();
        }


        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            LoadForm(settingsForm);
        }
        private void btnPlayerRanking_Click(object sender, EventArgs e)
        {
            PlayerRankingForm playerRankingForm = new PlayerRankingForm();
            LoadForm(playerRankingForm);
        }
        private void btnFavorite_Click(object sender, EventArgs e)
        {
            FormCountries countriesForm = new FormCountries();
            LoadForm(countriesForm);

        }
        private void btnRankingMatches_Click(object sender, EventArgs e)
        {
            RankingMatchesForm rankingMatchesForm = new RankingMatchesForm();
            LoadForm(rankingMatchesForm);
        }

        private void LoadForm(Form form)
        {
            pnlMain.Controls.Clear();
            if (form == null) return;
            EditFormSettings(form);
            pnlMain.Controls.Add(form);
            form.Show();
        }

        private Form EditFormSettings(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            return form;
        }
        private void SetLanguage()
        {
            Utility.Utility.SetLanguage(this, optionsFile);
            this.Controls.Clear();
            this.InitializeComponent();
            Settings();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = CheckResult();
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private DialogResult CheckResult()
        {
            return MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        }

        private void pbMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }
        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
