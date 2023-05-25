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
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;

namespace WinFormsApp1.Forms
{
    public partial class RankingMatchesForm : Form
    {
        private const string optionsFile = "options.txt";
        public RankingMatchesForm()
        {
            InitializeComponent();
            SetLanguage();
            LoadTeamsAsync();
        }

        private void SetLanguage()
        {
            Utility.Utility.SetLanguage(this,optionsFile);
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

            LoadSelectedCountry();
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
            Utility.Utility.CompareColumns(matchesList, columnForSorting, false);
        }

        private void cbTeamsRanking_SelectedIndexChanged(object sender, EventArgs e)
        {
            Team countryCode = (Team)cbTeamsRanking.SelectedItem;
            string fifaCode = countryCode.fifa_code;
            LoadDataAsync(fifaCode);
        }

        private void LoadSelectedCountry()
        {
            string filePath = Path.Combine(Application.StartupPath, "favorite_teams.txt");
            if (File.Exists(filePath))
            {
                string lastSavedCountry = File.ReadAllText(filePath);
                foreach (Team team in cbTeamsRanking.Items)
                {
                    if (team.country == lastSavedCountry)
                    {
                        cbTeamsRanking.SelectedItem = team;
                        break;
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument();
        }

        private void PrintDocument()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataGridView dataGridView = dataGridRanking; // Your DataGridView
            float currentY = 40; // The y coordinate of the current line

            // Header
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                e.Graphics.DrawString(column.HeaderText, dataGridView.Font, Brushes.Black, column.DisplayIndex * 150, currentY);
            }

            currentY += 50;

            // Rows
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    e.Graphics.DrawString(Convert.ToString(cell.Value), dataGridView.Font, Brushes.Black, cell.ColumnIndex * 150, currentY);
                }

                currentY += 50;
            }
        }
    }
}
