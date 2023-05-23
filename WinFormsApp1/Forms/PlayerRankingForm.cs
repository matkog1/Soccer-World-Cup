using SoccerDAL.AllRepos.Interfaces;
using SoccerDAL.AllRepos.MenRepos.MenAllMatches;
using SoccerDAL.AllRepos.WomenRepos.WomenAllMatches;
using SoccerDAL.Comparer;
using SoccerDAL.Models;
using SoccerDAL.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Forms
{
    public partial class PlayerRankingForm : Form
    {
        //za sortiranje columna na klik
        int currentColumnIndex = -1;
        bool ascending = true;
        public PlayerRankingForm()
        {
            InitializeComponent();
            LoadAsync();
            SetLanguage();
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

        private static async Task<List<Matches>> GetMatches()
        {
            string championship = GetChampionship();
            IRepoAllMatches matchesRepo;

            matchesRepo = CheckChampionshipType(championship);

            IList<Matches> matches = await matchesRepo.GetAllMatches();
            List<Matches> matches1 = matches.ToList();
            return matches1;
        }

        private static IRepoAllMatches CheckChampionshipType(string championship)
        {
            IRepoAllMatches matchesRepo;
            if (championship == "Men")
            {
                matchesRepo = MenRepoFactoryAllMatches.GetRepo();
            }
            else if (championship == "Women")
            {
                matchesRepo = WomenRepoFactoryAllMatches.GetRepo();
            }
            else
            {
                throw new Exception();
            }

            return matchesRepo;
        }

        private static string GetChampionship()
        {
            string filePath = Path.Combine(Application.StartupPath, "options.txt");
            string[] lines = File.ReadAllLines(filePath);
            string chosen = lines[0];
            return chosen;
        }

        private async Task LoadAsync()
        {
            List<Matches> AllMatches = await GetMatches();
            List<GoalEvents> goalsList = new List<GoalEvents>();

            GetEvents(AllMatches, goalsList);

            var groupedStats = goalsList.GroupBy(g => g.player).Select(group => new PlayerStats
            {
                Player = group.Key,
                Goals = group.Count(g => g.type_of_event == "goal" || g.type_of_event == "goal-penalty"),
                YellowCards = group.Count(g => g.type_of_event == "yellow-card")
            }).ToList();

            dataGridPlayers.DataSource = groupedStats;
        }

        private static void GetEvents(List<Matches> AllMatches, List<GoalEvents> goalsList)
        {
            foreach (var items in AllMatches)
            {
                foreach (var item in items.home_team_events)
                {
                    if (item.type_of_event == "goal" || item.type_of_event == "goal-penalty" || item.type_of_event == "yellow-card")
                    {
                        goalsList.Add(new GoalEvents
                        {
                            id = (int)item.id,
                            type_of_event = item.type_of_event,
                            player = item.player,
                            time = item.time
                        });
                    }
                }

                foreach (var item in items.away_team_events)
                {
                    if (item.type_of_event == "goal" || item.type_of_event == "goal-penalty" || item.type_of_event == "yellow-card")
                    {
                        goalsList.Add(new GoalEvents
                        {
                            id = (int)item.id,
                            type_of_event = item.type_of_event,
                            player = item.player,
                            time = item.time
                        });
                    }
                }

            }
        }
        private void dataGridPlayers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            var dataSource = dataGridPlayers.DataSource as List<PlayerStats>;

            if (dataSource != null)
            {
                // If the same column was clicked again, toggle the sort direction
                if (e.ColumnIndex == currentColumnIndex)
                {
                    ascending = !ascending;
                }
                else
                {
                    ascending = true;
                    currentColumnIndex = e.ColumnIndex;
                }

                dataGridPlayers.DataSource = SortingColumnMethod(e, dataSource);
            }
        }

        private List<PlayerStats>? SortingColumnMethod(DataGridViewCellMouseEventArgs e, List<PlayerStats>? dataSource)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    dataSource = ascending ? dataSource.OrderBy(x => x.Player).ToList()
                    : dataSource.OrderByDescending(x => x.Player).ToList();
                    break;
                case 1:
                    dataSource = ascending ? dataSource.OrderBy(x => x.Goals).ToList()
                    : dataSource.OrderByDescending(x => x.Goals).ToList();
                    break;
                case 2:
                    dataSource = ascending ? dataSource.OrderBy(x => x.YellowCards).ToList()
                    : dataSource.OrderByDescending(x => x.YellowCards).ToList();
                    break;
            }

            return dataSource;
        }
    }
}
