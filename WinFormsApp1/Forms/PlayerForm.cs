using SoccerDAL.AllRepos.Interfaces;
using SoccerDAL.AllRepos.MenRepos.MenAllMatches;
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

namespace WinFormsApp1.Forms
{
    public partial class PlayerForm : Form
    {
        public PlayerForm()
        {
            InitializeComponent();
            LoadAsync();
        }

        private async Task LoadAsync()
        {
            List<Matches> AllMatches = await GetMatches();
            List<GoalEvents> goalsList = new List<GoalEvents>();

            GetGoalEvents(AllMatches, goalsList);

            var groupedStats = goalsList.GroupBy(g => g.player).Select(group => new PlayerStats
            {
                Player = group.Key,
                Goals = group.Count(g => g.type_of_event == "goal" || g.type_of_event == "goal-penalty"),
                YellowCards = group.Count(g => g.type_of_event == "yellow-card")
            }).ToList();
            dataGridPlayers.DataSource = groupedStats;
            Utility.CompareColumns(groupedStats, "YellowCards", false);
        }

        private static void GetGoalEvents(List<Matches> AllMatches, List<GoalEvents> goalsList)
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

        private static async Task<List<Matches>> GetMatches()
        {
            IRepoAllMatches matchesRepo = MenRepoFactoryAllMatches.GetRepo();
            IList<Matches> matches = await matchesRepo.GetAllMatches();
            List<Matches> matches1 = matches.ToList();
            return matches1;
        }
    }
}
