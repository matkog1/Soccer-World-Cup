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
            LoadPlayers();
        }

        private async Task LoadPlayers()
        {
            IRepoPlayer playerRepository = MenRepoFactoryPlayer.GetRepo();
            var playersDictionary = playerRepository.GetPlayersFromJsonFile();


        }

        private void PrintDictionaryToTextBox(Dictionary<string, List<Player>> playersDictionary)
        {

            StringBuilder sb = new StringBuilder();

            foreach (var entry in playersDictionary)
            {
                string country = entry.Key;
                List<Player> players = entry.Value;

                sb.AppendLine($"Country: {country}");
                sb.AppendLine("Players:");

                foreach (Player player in players)
                {
                    sb.AppendLine($"Name: {player.Name}, Captain: {player.Captain}, Shirt Number: {player.Shirt_Number}, Position: {player.Position}, Country: {player.Country}");
                }

                sb.AppendLine();
            }

            cbPlayers.Text = sb.ToString();
        }

        private async Task LoadTeams()
        {
            IRepoTeams teamsRepo = MenRepoFactoryTeams.GetRepo();
            IList<Team> teamsList = await teamsRepo.GetAllTeams();
            List<Team> teams = teamsList.ToList();
            PrintTeams(teams);
            LoadSelectedCountry();
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
