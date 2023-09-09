using SoccerDAL.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_WorldCup
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        
        private const string resolutionFile = "resolution.txt";
        private const string championshipFile = "championship.txt";
        public LoginWindow()
        {
            InitializeComponent();
            LoadLastUsedResolution();
            LoadLastUsedChampionship();

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

                // Set window dimensions
                string[] dimensions = lastUsedResolution.Split('x');
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
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnResolutionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)cbResolution.SelectedItem;
            string selectedResolution = selectedItem.Content.ToString();

            // Write to a text file
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, resolutionFile);
            File.WriteAllText(filePath, selectedResolution);

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
    }
}
