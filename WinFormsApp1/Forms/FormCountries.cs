using SoccerDAL.AllRepos.Interfaces;
using SoccerDAL.AllRepos.MenRepos.MenPlayers;
using System.Numerics;
using SoccerDAL;
using SoccerDAL.Models;
using SoccerDAL.AllRepos.MenRepos.MenTeams;

namespace WinFormsApp1
{
    public partial class FormCountries : Form
    {

        public FormCountries()
        {
            InitializeComponent();
            LocationSettings();
            LoadTeams();
        }



        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SaveSelectedCountry();
        }

        private async Task LoadPlayers()
        {
            IRepoPlayer repo = MenRepoFactoryPlayer.GetRepo();
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
        private async Task LoadTeams()
        {
            IRepoTeams teamsRepo = MenRepoFactoryTeams.GetRepo();
            IList<Team> teamsList = await teamsRepo.GetAllTeams();
            List<Team> teams = teamsList.ToList();
            PrintTeams(teams);
            LoadSelectedCountry();
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

        private void LocationSettings()
        {
            int centerX = this.Width / 2;
            int centerY = this.Height / 2;

            int groupBoxX = centerX - (groupboxFavoriteTeams.Width / 2);
            int groupBoxY = centerY - (groupboxFavoriteTeams.Height / 2);

            groupboxFavoriteTeams.Location = new Point(groupBoxX, groupBoxY);
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