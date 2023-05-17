using SoccerDAL.AllRepos.Interfaces;
using SoccerDAL.AllRepos.MenRepos.MenPlayers;
using System.Numerics;
using SoccerDAL;
using SoccerDAL.Models;
using SoccerDAL.AllRepos.MenRepos.MenTeams;
using System.Globalization;
using SoccerDAL.AllRepos.WomenRepos.WomenTeams;
using SoccerDAL.AllRepos.WomenRepos.WomenPlayers;

namespace WinFormsApp1
{
    public partial class FormCountries : Form
    {

        public FormCountries()
        {
            InitializeComponent();
            SetLanguage();
            LoadTeams();
        }

        private void SetLanguage()
        {
            string filePath = Path.Combine(Application.StartupPath, "options.txt");
            string[] language = File.ReadAllLines(filePath);
            string chosenLanguage = language[1];

   
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

            Thread.CurrentThread.CurrentUICulture = culture;

            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SaveSelectedCountry();
        }

        private async Task LoadPlayers()
        {
            string championship = GetChampionshipType();
            IRepoPlayer repo;
            repo = CheckChampionShipType(championship);
            Dictionary<string, List<Player>> _playersByCountry = repo.GetPlayersByCountryFromJsonFile();
            if (_playersByCountry != null)
            {
                Team selectedTeam = (Team)cbTeams.SelectedItem;
                if (selectedTeam != null)
                {
                    string selectedCountry = selectedTeam.country;
                    if (_playersByCountry.ContainsKey(selectedCountry))
                    {
                        List<Player> players = _playersByCountry[selectedCountry];
                        cbCountryPlayers.DataSource = players;
                        cbCountryPlayers.DisplayMember = "Name";

                    }
                }
            }

        }

        private static IRepoPlayer CheckChampionShipType(string championship)
        {
            IRepoPlayer repo;
            if (championship == "Men")
            {
                repo = MenRepoFactoryPlayer.GetRepo(); 
            }
            else if (championship == "Women")
            {
                repo = WomenRepoFactoryPlayer.GetRepo(); 
            }
            else
            {
                throw new Exception();
            }

            return repo;
        }

        private async Task LoadTeams()
        {
            string championship = GetChampionshipType();
            IRepoTeams teamsRepo; // Declare the variable here

            teamsRepo = LoadChampionship(championship);

            IList<Team> teamsList = await teamsRepo.GetAllTeams();
            List<Team> teams = teamsList.ToList();
            PrintTeams(teams);
            LoadSelectedCountry();
        }

        private static IRepoTeams LoadChampionship(string championship)
        {
            IRepoTeams teamsRepo;
            if (championship == "Men")
            {
                teamsRepo = MenRepoFactoryTeams.GetRepo(); // Assign the variable here
            }
            else if (championship == "Women")
            {
                teamsRepo = WomenRepoFactoryTeams.GetRepo(); // Assign the variable here
            }
            else
            {
                throw new Exception("Invalid championship type");
            }

            return teamsRepo;
        }

        private string GetChampionshipType()
        {
            string filePath = Path.Combine(Application.StartupPath, "options.txt");
            string[] language = File.ReadAllLines(filePath);
            string chosenLanguage = language[0];
            return chosenLanguage;
        }

        private void cbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        private void PrintTeams(List<Team> teams)
        {
            cbTeams.DataSource = teams;
            cbTeams.DisplayMember = "Name";
            cbTeams.ValueMember = "Country";
            cbTeams.Format += (s, e) =>
            {
                if (e.ListItem != null)
                {
                    var team = (Team)e.ListItem;
                    e.Value = $"{team.country}, ({team.fifa_code})";
                }
            };
            cbTeams.SelectedIndexChanged += cbTeams_SelectedIndexChanged;
        }


        private void LoadSelectedCountry()
        {
            string filePath = Path.Combine(Application.StartupPath, "favorite_teams.txt");
            if (File.Exists(filePath))
            {
                string lastSavedCountry = File.ReadAllText(filePath);
                foreach (Team team in cbTeams.Items)
                {
                    if (team.country == lastSavedCountry)
                    {
                        cbTeams.SelectedItem = team;
                        break;
                    }
                }
            }
        }

        private void SaveSelectedCountry()
        {
            string filePath = Path.Combine(Application.StartupPath, "favorite_teams.txt");
            Team selectedTeam = (Team)cbTeams.SelectedItem;
            if (selectedTeam != null)
            {
                string country = selectedTeam.country;
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(country);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Player selectedPlayer = (Player)cbCountryPlayers.SelectedItem;
            selectedPlayer.Favorite = true;

            if (selectedPlayer != null)
            {
                dataGridPlayers.Rows.Add(
                    selectedPlayer.Name,
                    selectedPlayer.Shirt_Number,
                    selectedPlayer.Position,
                    selectedPlayer.Captain,
                    selectedPlayer.Favorite
                    );
            }
            dataGridPlayers.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}