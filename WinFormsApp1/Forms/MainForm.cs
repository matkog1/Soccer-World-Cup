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
        private SettingsForm settingsForm;
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
    }
}
