using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            LocationSettings();
            SetLanguage();
            Load();
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

        private void LocationSettings()
        {
            int centerX = this.Width / 2;
            int centerY = this.Height / 2;

            int groupBoxX = centerX - (groupboxLogin.Width / 2);
            int groupBoxY = centerY - (groupboxLogin.Height / 2);

            groupboxLogin.Location = new Point(groupBoxX, groupBoxY);
        }


        private void Load()
        {
            string[] optionsChampionships = { "", "Men", "Women" };
            string[] optionsLanguage = { "", "Croatian", "English" };

            cbChampionship.Items.AddRange(optionsChampionships);
            cbLanguage.Items.AddRange(optionsLanguage);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string selectedChampionship = cbChampionship.SelectedItem as string;
            string selectedLanguage = cbLanguage.SelectedItem as string;

            if (string.IsNullOrEmpty(selectedChampionship) || string.IsNullOrEmpty(selectedLanguage))
            {
                MessageBox.Show("Please select options in both ComboBoxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string filePath = Path.Combine(Application.StartupPath, "options.txt");

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(selectedChampionship);
                    writer.WriteLine(selectedLanguage);
                }

                MessageBox.Show("Options saved to file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            SetLanguage();
        }
    }
}
