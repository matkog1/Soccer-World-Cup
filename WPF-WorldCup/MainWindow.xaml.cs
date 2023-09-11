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
using System.Resources;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Interop;
using System.Reflection;
using System.Globalization;
using System.Threading;
using System.Windows.Input;
using System.Numerics;

namespace WPF_WorldCup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string resolutionFile = "resolution.txt";
        private const string championship = "championship.txt";
        private const string language = "language.txt";
        public ObservableCollection<Matches> Matches { get; set; }
        ResourceManager? resourceManager;
        public MainWindow()
        {
            InitializeComponent();
            Matches = new ObservableCollection<Matches>();
            this.DataContext = this;
            CheckResolutionAsync();
            LoadTeamsAsync();
            LoadData();
        }



        private void LoadData()
        {
            switch (LoadLastUsedLanguage())
            {
                case "English":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    resourceManager = new ResourceManager("WPF_WorldCup.Resources.en-MainWindow", typeof(MainWindow).Assembly);
                    break;
                case "Croatian":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("hr-HR");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("hr-HR");
                    resourceManager = new ResourceManager("WPF_WorldCup.Resources.hr-MainWindow", typeof(MainWindow).Assembly);
                    break;
                default:
                    break;
            }

            if (resourceManager != null)
            {

                btnExit.Content = resourceManager.GetString("btnExit");
                btnSettings.Content = resourceManager.GetString("btnSettings");
                lbLogo.Content = resourceManager.GetString("lbLogo");
            }
        }

        private async Task CheckResolutionAsync()
        {
            while (true)
            {
                LoadLastUsedResolution();
                LoadData();
                await Task.Delay(1);
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
                // Log or display the exception message
                MessageBox.Show("No language");
                return "Croatian";
            }

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
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.Show();
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
                    // Do nothing
                    break;
                case MessageBoxResult.Cancel:
                    // Do nothing
                    break;
            }
        }

        private async void DisplayButton_ClickAsync(object sender, RoutedEventArgs e)
        {
            // Get the current button.
            Button button = sender as Button;

            // Get the match associated with this button.
            Matches match = button.DataContext as Matches;

            // Await the asynchronous GetTeamsResults method
            List<TeamResults> allTeamsResults = await GetTeamsResults();


            // Pass the filtered results to the TeamsOverview constructor
            TeamsOverview teamsOverview = new TeamsOverview(allTeamsResults, match);
            teamsOverview.Show();
            

        }

        private async void FormationButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the current button.
            Button button = sender as Button;

            // Get the match associated with this button.
            Matches match = button.DataContext as Matches;

            AddPlayersToField(match);

        }


        private void AddPlayersToField(Matches match)
        {
            // Assuming match.home_team_statistics.starting_eleven is an array
            // of a class that contains player information.
            Starting_Eleven[] startingElevenHomeTeam = match.home_team_statistics.starting_eleven;
            Starting_Eleven1[] startingElevenAwayTeam = match.away_team_statistics.starting_eleven;

            // Remove old players from the grid first, if necessary.
            //field.Children.Clear();

            // Declare a counter variable outside the foreach loop
            int defenderIndex = 0, midfielderIndex = 0, forwardIndex = 0;

            // Initialize the grid coordinates for each type of player
            int[] defenderRowsHome = { 1 };
            int[] defenderColumnsHome = {1, 2,3 ,4,5, 6,7 };
            int[] midfielderRowsHome = { 2 };
            int[] midfielderColumnsHome = {1, 2, 3, 4, 5, 6, 7 };
            int[] forwardRowsHome = { 3 };
            int[] forwardColumnsHome = {1, 2, 3, 4, 5, 6, 7 };

            int totalRows = 8;  // Total rows in the grid
            int totalCols = 8;  // Total columns in the grid

            int defenderIndexHome = 0;
            int midfielderIndexHome = 0;
            int forwardIndexHome = 0;

            foreach (var playerInfo in startingElevenHomeTeam)
            {
                Player player = new Player();
                player.Name = playerInfo.name;
                player.Shirt_Number = playerInfo.shirt_number;
                player.Captain = playerInfo.captain;
                player.Position = playerInfo.position;

                PlayerIcon playerIcon = new PlayerIcon();
                playerIcon.Tag = player;
                playerIcon.MouseLeftButtonUp += PlayerIcon_MouseLeftButtonUp;
                playerIcon.lbName.Content = player.Name;

                // Place player in grid according to their position
                switch (player.Position)
                {
                    case "Goalie":
                        Grid.SetRow(playerIcon, 0);
                        Grid.SetColumn(playerIcon, 4);
                        break;

                    case "Defender":
                        Grid.SetRow(playerIcon, defenderRowsHome[defenderIndexHome / defenderColumnsHome.Length]);
                        Grid.SetColumn(playerIcon, defenderColumnsHome[defenderIndexHome % defenderColumnsHome.Length]);
                        defenderIndexHome++;
                        break;

                    case "Midfield":
                        Grid.SetRow(playerIcon, midfielderRowsHome[midfielderIndexHome / midfielderColumnsHome.Length]);
                        Grid.SetColumn(playerIcon, midfielderColumnsHome[midfielderIndexHome % midfielderColumnsHome.Length]);
                        midfielderIndexHome++;
                        break;

                    case "Forward":
                        Grid.SetRow(playerIcon, forwardRowsHome[forwardIndexHome / forwardColumnsHome.Length]);
                        Grid.SetColumn(playerIcon, forwardColumnsHome[forwardIndexHome % forwardColumnsHome.Length]);
                        forwardIndexHome++;
                        break;
                }

                // Add the player to the grid
                field.Children.Add(playerIcon);
            }



            int goalkeeperRowAway = 6;  // Last row for Away Team
            int goalkeeperColumnAway = 3;  // Middle column

            int[] defenderRowsAway = { 5 };
            int[] defenderColumnsAway = {1, 2, 3, 4, 5, 6, 7 };

            int[] midfielderRowsAway = { 4 };
            int[] midfielderColumnsAway = {1, 2, 3, 4, 5, 6, 7 };

            int[] forwardRowsAway = { 3 };
            int[] forwardColumnsAway = {1, 2, 3, 4, 5, 6, 7 };

            int defenderIndexAway = 0, midfielderIndexAway = 0, forwardIndexAway = 0;

            foreach (var playerInfo in startingElevenAwayTeam)
            {
                PlayerIcon playerIcon = new PlayerIcon();
                playerIcon.lbName.Content = playerInfo.name;
                playerIcon.MouseLeftButtonUp += PlayerIcon_MouseLeftButtonUp;

                // (set other properties here)

                // Place player in grid according to their position
                switch (playerInfo.position)
                {
                    case "Goalie":
                        Grid.SetRow(playerIcon, goalkeeperRowAway);
                        Grid.SetColumn(playerIcon, goalkeeperColumnAway);
                        break;

                    case "Defender":
                        Grid.SetRow(playerIcon, defenderRowsAway[defenderIndexAway / defenderColumnsAway.Length]);
                        Grid.SetColumn(playerIcon, defenderColumnsAway[defenderIndexAway % defenderColumnsAway.Length]);
                        defenderIndexAway++;
                        break;

                    case "Midfield":
                        Grid.SetRow(playerIcon, midfielderRowsAway[midfielderIndexAway / midfielderColumnsAway.Length]);
                        Grid.SetColumn(playerIcon, midfielderColumnsAway[midfielderIndexAway % midfielderColumnsAway.Length]);
                        midfielderIndexAway++;
                        break;

                    case "Forward":
                        Grid.SetRow(playerIcon, forwardRowsAway[forwardIndexAway / forwardColumnsAway.Length]);
                        Grid.SetColumn(playerIcon, forwardColumnsAway[forwardIndexAway % forwardColumnsAway.Length]);
                        forwardIndexAway++;
                        break;
                }

                // Add the player to the grid
                field.Children.Add(playerIcon);

            }
        }
        private void PlayerIcon_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (sender is PlayerIcon playerIcon)
            {
                // Retrieve the Player object from the Tag property
                if (playerIcon.Tag is Player player)
                {
                    // Create and populate the PlayerWindow
                    PlayerWindow playerWindow = new PlayerWindow();
                    playerWindow.lbShowPlayerName.Content = player.Name;
                    playerWindow.lbShowShirtNumber.Content = player.Shirt_Number;
                    playerWindow.lbShowPosition.Content = player.Position;
                    playerWindow.lbShowCaptain.Content = player.Captain ? "Yes" : "No";

                    // Show the window
                    playerWindow.ShowDialog();
                }
            }
        }

    }
} 

 
