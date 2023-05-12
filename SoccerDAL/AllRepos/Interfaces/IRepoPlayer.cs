using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.Interfaces
{
    public interface IRepoPlayer
    {
        public HashSet<Player> GetPlayersFromJsonFile();
        public Dictionary<string, List<Player>> GetPlayersByCountryFromJsonFile();
    }

}
