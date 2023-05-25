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
            SetLanguage();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            LoadForm(settingsForm);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            PlayerRankingForm playerRankingForm = new PlayerRankingForm();
            LoadForm(playerRankingForm);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormCountries countriesForm = new FormCountries();
            LoadForm(countriesForm);

        }
        private void button3_Click(object sender, EventArgs e)
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
        }

    }
}
