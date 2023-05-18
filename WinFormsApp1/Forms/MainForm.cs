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
        public MainForm()
        {
            Reload();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            LoadSettingsForm();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            LoadPlayerRankingForm();
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
        private void LoadPlayerRankingForm()
        {
            PlayerForm playerRankingForm = new PlayerForm();
            playerRankingForm.TopLevel = false;
            playerRankingForm.FormBorderStyle = FormBorderStyle.None;
            playerRankingForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(playerRankingForm);
            playerRankingForm.Show();
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

        private void LoadSettingsForm()
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
        private void SetLanguage()
        {
            string filePath = Path.Combine(Application.StartupPath, "options.txt");
            string[] language = File.ReadAllLines(filePath);
            string chosenLanguage = language[1];

            // Convert the language to a CultureInfo
            CultureInfo culture;
            switch (chosenLanguage)
            {
                case "Croatian":
                    culture = new CultureInfo("hr");
                    break;
                default:
                    culture = new CultureInfo("en");
                    break;
            }

            // Change the culture of the current thread
            Thread.CurrentThread.CurrentUICulture = culture;

            // Reload the form to apply the new culture
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void Reload()
        {
            InitializeComponent();
            LoadSettingsForm();
            SetLanguage();
        }
    }
}
