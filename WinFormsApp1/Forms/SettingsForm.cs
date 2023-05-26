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
        private const string optionsFile = "options.txt";
        public SettingsForm()
        {
            InitializeComponent();
            SetLanguage();
            Load();
        }

        private void SetLanguage()
        {
            Utility.Utility.SetLanguage(this, optionsFile);
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
                ShowErrorMessage();
                return;
            }
            DialogResult result = ConfirmSaveMessage();

            if (result == DialogResult.Yes)
            {
                SaveToFile(selectedChampionship, selectedLanguage, optionsFile);
                ShowPrintMessage();
                SetLanguage();
            }
        }

        private static DialogResult ConfirmSaveMessage()
        {
            return MessageBox.Show("Are you sure you want to save?", "Saving...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        private void ShowErrorMessage()
        {
            MessageBox.Show("Please select options in both ComboBoxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowPrintMessage()
        {
            MessageBox.Show("Options saved to file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveToFile(string selectedChampionship, string selectedLanguage, string optionsFile)
        {
            string filePath = Path.Combine(Application.StartupPath, optionsFile);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(selectedChampionship);
                writer.WriteLine(selectedLanguage);
            }
        }


    }
}
