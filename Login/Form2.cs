using SoccerDAL.AllRepos.PlayerRepo;
using SoccerDAL.AllRepos.TeamsRepo;
using SoccerDAL.AllRepos.WomenRepos.WomenPlayers;
using SoccerDAL.AllRepos.WomenRepos.WomenTeams;
using SoccerDAL.Comparer;
using SoccerDAL.Models;
using SoccerDAL.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadTeams();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSelectedCountry();
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

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }

}
