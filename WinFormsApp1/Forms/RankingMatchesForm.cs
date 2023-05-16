using Microsoft.VisualBasic;
using SoccerDAL.AllRepos.Interfaces;
using SoccerDAL.AllRepos.MenRepos.MenAllMatchesByCountry;
using SoccerDAL.AllRepos.MenRepos.MenTeams;
using SoccerDAL.Comparer;
using SoccerDAL.Models;
using SoccerDAL.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            LoadTeamsAsync();
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
            IRepoTeams teamsRepo = MenRepoFactoryTeams.GetRepo();
            IList<Team> teamsList = await teamsRepo.GetAllTeams();
            List<Team> teams = teamsList.ToList();
            return teams;
        }


        private async Task GetRankingAsync(string fifaCode)
        {

            IRepoAllMatchesByCountry matchesRepoByCountry = MenRepoFactoryMatchesCountry.GetRepo();
            IList<Matches> matchesCountry = await matchesRepoByCountry.MatchesByCountry(fifaCode);
            List<Matches> matchesList = matchesCountry.ToList();
            PrintMatchesToDataGrid(matchesList);
            SortColumns(matchesList, "attendance", false);
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
