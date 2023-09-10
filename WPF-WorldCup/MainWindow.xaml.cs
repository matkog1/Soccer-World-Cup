using SoccerDAL.AllRepos.Interfaces;
using SoccerDAL.AllRepos.MenRepos.MenAllMatchesByCountry;
using SoccerDAL.AllRepos.MenRepos.MenTeams;
using SoccerDAL.AllRepos.MenRepos.MenTeamsResults;
using SoccerDAL.AllRepos.WomenRepos.WomenAllMatchesByCountry;
using SoccerDAL.AllRepos.WomenRepos.WomenTeams;
using SoccerDAL.AllRepos.WomenRepos.WomenTeamsResults;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Interop;

namespace WPF_WorldCup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string resolutionFile = "resolution.txt";
        private const string championship = "championship.txt";
        public ObservableCollection<Matches> Matches { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Matches = new ObservableCollection<Matches>();
            this.DataContext = this;
            LoadLastUsedResolution();
            LoadTeamsAsync();
        }

        private async void cbTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Team selectedTeam = (Team)cbTeams.SelectedItem;
            if (selectedTeam != null)
            {
                string fifaCode = selectedTeam.fifa_code;
                await LoadMatchesByCountryAsync(fifaCode);

            }
        }

        private async Task<List<Matches>> LoadMatchesByCountryAsync(string fifaCode)
        {
            string championship = GetChampionshipType();
            IRepoAllMatchesByCountry matchesRepoByCountry = Check(championship);

            IList<Matches> matchesCountry = await matchesRepoByCountry.MatchesByCountry(fifaCode);
            Matches.Clear();
            foreach (var match in matchesCountry)
            {
                Matches.Add(match);
            }
            return matchesCountry.ToList();
        }



        private void LoadLastUsedResolution()
        {
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, resolutionFile);
            if (File.Exists(filePath))
            {
                string lastUsedResolution = File.ReadAllText(filePath);

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

            InitializeComponent();
        }

        private async Task LoadTeamsAsync()
        {
            var teams = await GetTeams();
            cbTeams.ItemsSource = teams;

            // Define a DataTemplate for the ComboBox items
            var itemTemplate = new DataTemplate();
            var factory = new FrameworkElementFactory(typeof(TextBlock));
            factory.SetBinding(TextBlock.TextProperty, new Binding("country") { StringFormat = "{0}, " });
            factory.SetBinding(TextBlock.TextProperty, new Binding("fifa_code"));
            itemTemplate.VisualTree = factory;
            cbTeams.ItemTemplate = itemTemplate;

        }

        private static async Task<List<Team>> GetTeams()
        {
            string championship = GetChampionshipType();
            IRepoTeams teamsRepo;

            teamsRepo = CheckChampionshipType(championship);
            IList<Team> teamsList = await teamsRepo.GetAllTeams();
            List<Team> teams = teamsList.ToList();
            return teams;
        }

        private static async Task<List<TeamResults>> GetTeamsResults()
        {
            string championship = GetChampionshipType();
            IRepoTeamsResults teamsResults;

            teamsResults = CheckTeamResults(championship);
            IList<TeamResults> teamsList = await teamsResults.GetTeamsResults();
            List<TeamResults> teams = teamsList.ToList();
            return teams;
        }

        private static IRepoTeams CheckChampionshipType(string championship)
        {
            IRepoTeams teamsRepo;
            if (championship == "Men")
            {
                teamsRepo = MenRepoFactoryTeams.GetRepo();
            }
            else if (championship == "Women")
            {
                teamsRepo = WomenRepoFactoryTeams.GetRepo();
            }
            else
            {
                throw new Exception();
            }

            return teamsRepo;
        }

        private static string GetChampionshipType()
        {
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, championship);
            string[] lines = File.ReadAllLines(filePath);
            string chosen = lines[0];
            return chosen;
        }


        private static IRepoTeamsResults CheckTeamResults(string championship)
        {
            IRepoTeamsResults teamsResults;
            if (championship == "Men")
            {
                teamsResults = MenRepoFactoryTeamsResults.GetRepo();
            }
            else if (championship == "Women")
            {
                teamsResults = WomenRepoFactoryTeamsResults.GetRepo();
            }
            else
            {
                throw new Exception();
            }

            return teamsResults;
        }


        private static IRepoAllMatchesByCountry Check(string championship)
        {
            IRepoAllMatchesByCountry matchesRepoByCountry;
            if (championship == "Men")
            {
                matchesRepoByCountry = MenRepoFactoryMatchesCountry.GetRepo();
            }
            else if (championship == "Women")
            {
                matchesRepoByCountry = WomenRepoFactoryMatchesCountry.GetRepo();
            }
            else
            {
                throw new Exception();
            }

            return matchesRepoByCountry;
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void DisplayButton_ClickAsync(object sender, RoutedEventArgs e)
        {
            // Get the current button.
            Button button = sender as Button;

            // Get the match associated with this button.
            Matches match = button.DataContext as Matches;

            // Await the asynchronous GetTeamsResults method
            List<TeamResults> teamsResults = await GetTeamsResults();

            // Pass the awaited results to the TeamsOverview constructor
            TeamsOverview teamsOverview = new TeamsOverview(teamsResults);
            teamsOverview.Show();

        }
    }
}
