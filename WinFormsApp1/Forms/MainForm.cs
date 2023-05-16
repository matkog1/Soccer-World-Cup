using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;
using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            LoadSettings();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            LoadCountriesForm();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            LoadRankingForm();
        }

        private void LoadCountriesForm()
        {
            FormCountries countries = new FormCountries();
            countries.TopLevel = false;
            countries.FormBorderStyle = FormBorderStyle.None;
            countries.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(countries);
            countries.Show();
        }

        private void LoadSettings()
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.TopLevel = false;
            settingsForm.FormBorderStyle = FormBorderStyle.None;
            settingsForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(settingsForm);
            settingsForm.Show();
        }

        private void LoadRankingForm()
        {
            RankingMatchesForm rankingForm = new RankingMatchesForm();
            rankingForm.TopLevel = false;
            rankingForm.FormBorderStyle = FormBorderStyle.None;
            rankingForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(rankingForm);
            rankingForm.Show();
        }
    }
}
