using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_WorldCup
{
    /// <summary>
    /// Interaction logic for TeamsOverview.xaml
    /// </summary>
    public partial class TeamsOverview : Window
    {
        public ObservableCollection<TeamResults> TeamResults { get; set; }
        

        public TeamsOverview(List<TeamResults> teamsResults)
        {
            InitializeComponent();
            TeamResults = new ObservableCollection<TeamResults>(teamsResults);
            this.DataContext = this;
            listViewTeamOverview.ItemsSource = TeamResults;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
