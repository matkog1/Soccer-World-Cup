using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Resources;

namespace WPF_WorldCup
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        private const string resolutionFile = "resolution.txt";
        private const string championshipFile = "championship.txt";
        private const string languageFile = "language.txt";
        ResourceManager? resourceManager;

        public SettingsWindow()
        {
            InitializeComponent();
            LoadLastUsedResolution();
            LoadLastUsedChampionship();
            LoadLastUsedLanguage();
            LoadData();
        }

        private void LoadData()
        {
            switch (GetLanguage())
            {
                case "English":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    resourceManager = new ResourceManager("WPF_WorldCup.Resources.en-LoginWindow", typeof(MainWindow).Assembly);
                    break;
                case "Croatian":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("hr-HR");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("hr-HR");
                    resourceManager = new ResourceManager("WPF_WorldCup.Resources.hr-LoginWindow", typeof(MainWindow).Assembly);
                    break;
                default:
                    break;
            }

            if (resourceManager != null)
            {

                btnExit.Content = resourceManager.GetString("btnExit");
                lbChampionship.Content = resourceManager.GetString("lbChampionship");
                lbResolution.Content = resourceManager.GetString("lbResolution");
                lblanguage.Content = resourceManager.GetString("lblanguage");
            }
        }

        private string GetLanguage()
        {
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, languageFile);
            try
            {
                if (File.Exists(filePath))
                {
                    string lastUsedLanguage = File.ReadAllText(filePath);
                    return lastUsedLanguage;
                }
                else
                {
                    return "Croatian";
                }
            }
            catch (Exception e)
            {
                // Log or display the exception message
                MessageBox.Show("No language");
                return "Croatian";
            }
        }

        private void OnChampionshipChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)cbChampionship.SelectedItem;
            string selectedChampionship = selectedItem.Content.ToString();

            // Write to a text file
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, championshipFile);
            File.WriteAllText(filePath, selectedChampionship);
        }


        private void LoadLastUsedResolution()
        {
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, resolutionFile);
            if (File.Exists(filePath))
            {
                string lastUsedResolution = File.ReadAllText(filePath);

                // Set ComboBox selection
                foreach (ComboBoxItem item in cbResolution.Items)
                {
                    if (item.Content.ToString() == lastUsedResolution)
                    {
                        cbResolution.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
              "Are you sure you want to quit?",
              "Confirmation",
              MessageBoxButton.YesNoCancel,
              MessageBoxImage.Question,
              MessageBoxResult.Cancel);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    this.Close();
                    break;
                case MessageBoxResult.No:
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }
        }

        private void OnResolutionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)cbResolution.SelectedItem;
            string selectedResolution = selectedItem.Content.ToString();

            // Write to a text file
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, resolutionFile);
            File.WriteAllText(filePath, selectedResolution);
            /*
            // Update window size
            string[] dimensions = selectedResolution.Split('x');
            if (dimensions.Length == 2)
            {
                int newWidth = int.Parse(dimensions[0]);
                int newHeight = int.Parse(dimensions[1]);

                // Set new size
                this.Width = newWidth;
                this.Height = newHeight;

                // Center window
                this.Left = (SystemParameters.WorkArea.Width - newWidth) / 2;
                this.Top = (SystemParameters.WorkArea.Height - newHeight) / 2;
            }
            */
        }

        private void LoadLastUsedChampionship()
        {
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, championshipFile);
            if (File.Exists(filePath))
            {
                string lastUsedChampionship = File.ReadAllText(filePath);

                // Set ComboBox selection
                foreach (ComboBoxItem item in cbChampionship.Items)
                {
                    if (item.Content.ToString() == lastUsedChampionship)
                    {
                        cbChampionship.SelectedItem = item;
                        break;
                    }
                }
            }
        }


        private void LoadLastUsedLanguage()
        {
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, languageFile);
            if (File.Exists(filePath))
            {
                string lastUsedLanguage = File.ReadAllText(filePath);
                foreach (ComboBoxItem item in cbLanguage.Items)
                {
                    if (item.Content.ToString() == lastUsedLanguage)
                    {
                        cbLanguage.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void OnLanguageChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedLanguage = (cbLanguage.SelectedItem as ComboBoxItem).Content.ToString();
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, languageFile);
            File.WriteAllText(filePath, selectedLanguage);
            LoadData();
        }

    }
}
