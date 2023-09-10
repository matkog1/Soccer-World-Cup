using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Globalization;
using System.Threading;
using System.Resources;
using System.IO;

namespace WPF_WorldCup
{
    /// <summary>
    /// Interaction logic for TeamsOverview.xaml
    /// </summary>
    public partial class TeamsOverview : Window
    {
        public ObservableCollection<TeamResults> TeamResults { get; set; }

        private const string language = "language.txt";
        ResourceManager? resourceManager;

        public TeamsOverview(List<TeamResults> teamsResults, Matches match)
        {
            string home_team = match.home_team_country;
            string away_team = match.away_team_country;

            InitializeComponent();

            // Filter the team results based on the home_team and away_team countries from match
            var filteredTeamResults = teamsResults
                .Where(tr => tr.country == home_team || tr.country == away_team)
                .ToList();

            TeamResults = new ObservableCollection<TeamResults>(filteredTeamResults);
            this.DataContext = this;
            listViewTeamOverview.ItemsSource = TeamResults;
            LoadData();
        }

        private void LoadData()
        {
            switch (LoadLastUsedLanguage())
            {
                case "English":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    resourceManager = new ResourceManager("WPF_WorldCup.Resources.en-TeamsOverview", typeof(MainWindow).Assembly);
                    break;
                case "Croatian":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("hr-HR");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("hr-HR");
                    resourceManager = new ResourceManager("WPF_WorldCup.Resources.hr-TeamsOverview", typeof(MainWindow).Assembly);
                    break;
                default:
                    break;
            }

            if (resourceManager != null)
            {

                btnExit.Content = resourceManager.GetString("btnExit");
                lbWorldCup.Content = resourceManager.GetString("lbWorldCup");
                lbTeamsOverview.Content = resourceManager.GetString("lbTeamsOverview");
            }
        }

        private string LoadLastUsedLanguage()
        {
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, language);
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
                MessageBox.Show("No language");
                return "Croatian";
            }

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
