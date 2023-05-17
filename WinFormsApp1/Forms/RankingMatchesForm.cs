using Microsoft.VisualBasic;
using SoccerDAL.AllRepos.Interfaces;
using SoccerDAL.AllRepos.MenRepos.MenAllMatchesByCountry;
using SoccerDAL.AllRepos.MenRepos.MenTeams;
using SoccerDAL.AllRepos.WomenRepos.WomenAllMatchesByCountry;
using SoccerDAL.AllRepos.WomenRepos.WomenTeams;
using SoccerDAL.Comparer;
using SoccerDAL.Models;
using SoccerDAL.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Forms
{
    public partial class RankingMatchesForm : Form
    {
        public RankingMatchesForm()
        {
            InitializeComponent();
            SetLanguage();
            LoadTeamsAsync();
        }

        private void SetLanguage()
        {
            string filePath = Path.Combine(Application.StartupPath, "options.txt");
            string[] language = File.ReadAllLines(filePath);
            string chosenLanguage = language[1];

            // Convert the language to a CultureInfo
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

            // Change the culture of the current thread
            Thread.CurrentThread.CurrentUICulture = culture;

            // Reload the form to apply the new culture
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private async void LoadDataAsync(string fifaCode)
        {
            await GetRankingAsync(fifaCode);
        }

        private async Task LoadTeamsAsync()
        {
            cbTeamsRanking.DataSource = await GetTeams();
            cbTeamsRanking.Format += (s, e) =>
            {
                if (e.ListItem != null)
                {
                    var team = (Team)e.ListItem;
                    e.Value = $"{team.country},{team.fifa_code}";
                }
            };
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
            string filePath = Path.Combine(Application.StartupPath, "options.txt");
            string[] lines = File.ReadAllLines(filePath);
            string chosen = lines[0];
            return chosen;
        }

        private async Task GetRankingAsync(string fifaCode)
        {
            string championship = GetChampionshipType();
            IRepoAllMatchesByCountry matchesRepoByCountry;

            matchesRepoByCountry = Check(championship);

            IList<Matches> matchesCountry = await matchesRepoByCountry.MatchesByCountry(fifaCode);
            List<Matches> matchesList = matchesCountry.ToList();
            PrintMatchesToDataGrid(matchesList);
            SortColumns(matchesList, "attendance", false);
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

        private void PrintMatchesToDataGrid(List<Matches> matchesList)
        {
            dataGridRanking.AllowUserToOrderColumns = true;

            dataGridRanking.AutoGenerateColumns = false;
            dataGridRanking.Columns.Clear();

            var venueColumn = new DataGridViewTextBoxColumn
            {
                Name = "Venue",
                DataPropertyName = "venue",
                SortMode = DataGridViewColumnSortMode.Automatic
            };

            var attendanceColumn = new DataGridViewTextBoxColumn
            {
                Name = "Attendance",
                DataPropertyName = "attendance",
                SortMode = DataGridViewColumnSortMode.Automatic
            };

            var homeTeamColumn = new DataGridViewTextBoxColumn
            {
                Name = "Home Team",
                DataPropertyName = "home_team_country",
                SortMode = DataGridViewColumnSortMode.Automatic
            };

            var awayTeamColumn = new DataGridViewTextBoxColumn
            {
                Name = "Away Team",
                DataPropertyName = "away_team_country",
                SortMode = DataGridViewColumnSortMode.Automatic
            };

            dataGridRanking.Columns.Add(venueColumn);
            dataGridRanking.Columns.Add(attendanceColumn);
            dataGridRanking.Columns.Add(homeTeamColumn);
            dataGridRanking.Columns.Add(awayTeamColumn);

            dataGridRanking.DataSource = matchesList;

        }
        private void SortColumns(List<Matches> matchesList, string columnForSorting, bool order)
        {
            Utility.CompareColumns(matchesList, columnForSorting, false);
        }

        private void cbTeamsRanking_SelectedIndexChanged(object sender, EventArgs e)
        {
            Team countryCode = (Team)cbTeamsRanking.SelectedItem;
            string fifaCode = countryCode.fifa_code;
            LoadDataAsync(fifaCode);
        }
    }
}
