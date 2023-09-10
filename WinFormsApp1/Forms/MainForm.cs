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
        ResourceManager? resourceManager;
        public MainForm()
        {
            InitializeComponent();
            SetLanguage();
            LoadData();
        }

        private void LoadData()
        {
            switch (LoadLastUsedLanguage())
            {
                case "English":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    resourceManager = new ResourceManager("WinFormsApp1.Resources.en-MainForm", typeof(MainForm).Assembly);
                    break;
                case "Croatian":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("hr-HR");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("hr-HR");
                    resourceManager = new ResourceManager("WinFormsApp1.Resources.hr-MainForm", typeof(MainForm).Assembly);
                    break;
                default:
                    break;
            }

            if (resourceManager != null)
            {

                btnFavorite.Text = resourceManager.GetString("btnFavorite");
                btnSettings.Text = resourceManager.GetString("btnSettings");
                btnrankingMatches.Text = resourceManager.GetString("btnrankingMatches");
                btnPlayerRanking.Text = resourceManager.GetString("btnPlayerRanking");
            }
        }

        private string LoadLastUsedLanguage()
        {
            string filePath = Path.Combine(Application.StartupPath, optionsFile);
            if (!File.Exists(filePath))
            {
                File.ReadAllLines(filePath);
            }
            string[] language = File.ReadAllLines(filePath);
            string chosenLanguage = language[1];
            return chosenLanguage;
        }

        /*
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
        */
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
            FavoritesForm countriesForm = new FavoritesForm();
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
            string filePath = Path.Combine(Application.StartupPath, optionsFile);
            ResourceManager resourceManager = null;  // Declare the ResourceManager

            if (!File.Exists(filePath))
            {
                string defaultLanguage = "English";
                string defaultChampionship = "Men";
                string content = defaultChampionship + Environment.NewLine + defaultLanguage;
                File.WriteAllText(filePath, content);
            }

            string[] settings = File.ReadAllLines(filePath);
            string chosenLanguage = settings[1];

            CultureInfo culture;
            switch (chosenLanguage)
            {
                case "Croatian":
                    culture = new CultureInfo("hr");
                    resourceManager = new ResourceManager("WinFormsApp1.Resources.hr-MainForm", typeof(MainForm).Assembly);  // Initialize ResourceManager for Croatian
                    break;
                default:
                    culture = new CultureInfo("en");
                    resourceManager = new ResourceManager("WinFormsApp1.Resources.en-MainForm", typeof(MainForm).Assembly);  // Initialize ResourceManager for English
                    break;
            }
            Thread.CurrentThread.CurrentUICulture = culture;

            if (resourceManager != null)
            {

                btnFavorite.Text = resourceManager.GetString("btnFavorite");
                btnSettings.Text = resourceManager.GetString("btnSettings");
                btnrankingMatches.Text = resourceManager.GetString("btnrankingMatches");
                btnPlayerRanking.Text = resourceManager.GetString("btnPlayerRanking");
            }
            this.Controls.Clear();
            this.InitializeComponent();
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

        private void pictureBox2_Click_3(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
