using SoccerDAL.AllRepos.Interfaces;
using SoccerDAL.AllRepos.MenRepos.MenPlayers;
using System.Numerics;
using SoccerDAL;
using SoccerDAL.Models;
using SoccerDAL.AllRepos.MenRepos.MenTeams;
using System.Globalization;
using SoccerDAL.AllRepos.WomenRepos.WomenTeams;
using SoccerDAL.AllRepos.WomenRepos.WomenPlayers;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.CodeDom;

namespace WinFormsApp1
{
    public partial class FavoritesForm : Form
    {
        string favoriteTeams = "favorite_teams.txt";
        string optionsFile = "options.txt";
        public FavoritesForm()
        {
            InitializeComponent();
            SetLanguage();
            LoadTeams();
            DragAndDrop();
        }

        private void DragAndDrop()
        {
            flp1.AllowDrop = true;
            flp2.AllowDrop = true;

            // Attach event handlers for drag and drop events
            flp1.DragEnter += FlowLayoutPanel_DragEnter;
            flp1.DragDrop += FlowLayoutPanel_DragDrop;

            flp2.DragEnter += FlowLayoutPanel_DragEnter;
            flp2.DragDrop += FlowLayoutPanel_DragDrop;
        }
        private void FlowLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PlayerControl)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void FlowLayoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            PlayerControl playerControl = (PlayerControl)e.Data.GetData(typeof(PlayerControl));
            FlowLayoutPanel destination = (FlowLayoutPanel)sender;
            FlowLayoutPanel source = (FlowLayoutPanel)playerControl.Parent;

            // Perform the drag and drop operation
            source.Controls.Remove(playerControl);
            destination.Controls.Add(playerControl);

            // Update the ContextMenuStrip of the PlayerControl
            playerControl.ContextMenuStrip.Items[0].Enabled = destination == flp1;
        }

        private void SetLanguage()
        {
            Utility.Utility.SetLanguage(this, optionsFile);

        }

        private async Task LoadPlayers()
        {
            string championship = GetChampionshipType();
            IRepoPlayer repo = CheckChampionShipType(championship);

            Dictionary<string, List<Player>> _playersByCountry = repo.GetPlayersByCountryFromJsonFile();
            if (_playersByCountry == null) return;

            Team selectedTeam = cbTeams.SelectedItem as Team;
            if (selectedTeam?.country is string selectedCountry && _playersByCountry.TryGetValue(selectedCountry, out List<Player> players))
            {
                cbCountryPlayers.DataSource = players;
                cbCountryPlayers.DisplayMember = "Name";
                FillLayout(players);
            }
        }

        private void FillLayout(List<Player> players)
        {
            flp1.Controls.Clear();
            foreach (Player player in players)
            {
                PlayerControl playerControl = new PlayerControl();
                if (player != null)
                {
                    playerControl.PlayerName = player.Name;
                    playerControl.PlayerNumber = player.Shirt_Number;
                    playerControl.PlayerPosition = player.Position;
                    playerControl.PlayerCaptain = player.Captain;
                    playerControl.PlayerFavorite = player.Favorite;

                    flp1.Controls.Add(playerControl);
                }
            }
        }

        private void PlayerControl_RequestMove(object sender, EventArgs e)
        {
            PlayerControl playerControl = sender as PlayerControl;

            FlowLayoutPanel source = (FlowLayoutPanel)playerControl.Parent;
            FlowLayoutPanel destination = source == flp1 ? flp2 : flp1;

            // Perform the move operation
            source.Controls.Remove(playerControl);
            destination.Controls.Add(playerControl);
        }

        private static IRepoPlayer CheckChampionShipType(string championship)
        {

            IRepoPlayer repo;
            switch (championship)
            {
                case "Men":
                    repo = MenRepoFactoryPlayer.GetRepo();
                    break;
                case "Women":
                    repo = WomenRepoFactoryPlayer.GetRepo();
                    break;
                default:
                    throw new Exception("Invalid championship type");
            }
            return repo;
        }

        private async Task LoadTeams()
        {
            try
            {
                string championship = GetChampionshipType();
                IRepoTeams teamsRepo;

                teamsRepo = LoadChampionship(championship);

                IList<Team> teamsList = await teamsRepo.GetAllTeams();
                List<Team> teams = teamsList.ToList();
                PrintTeams(teams);
                LoadSelectedCountry();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static IRepoTeams LoadChampionship(string championship)
        {
            IRepoTeams teamsRepo;
            switch (championship)
            {
                case "Men":
                    teamsRepo = MenRepoFactoryTeams.GetRepo();
                    break;
                case "Women":
                    teamsRepo = WomenRepoFactoryTeams.GetRepo();
                    break;
                default:
                    throw new Exception("Invalid championship type");
            }
            return teamsRepo;
        }

        private string GetChampionshipType()
        {
            string filePath = Path.Combine(Application.StartupPath, optionsFile);
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
            string filePath = Path.Combine(Application.StartupPath, favoriteTeams);
            if (!File.Exists(filePath))
            {
                string defaulFavoriteCountry = "Croatia";
                File.WriteAllText(filePath, defaulFavoriteCountry);
            }

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

        private void SaveSelectedCountry()
        {
            string filePath = Path.Combine(Application.StartupPath, favoriteTeams);
            Team selectedTeam = cbTeams.SelectedItem as Team;

            if (selectedTeam?.country is string country)
            {
                File.WriteAllText(filePath, country);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSelectedCountry();
            MessageBox.Show("Country has been successfully saved.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}