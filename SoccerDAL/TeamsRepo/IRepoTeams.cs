using Newtonsoft.Json;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.TeamsRepo
{
    public interface IRepoTeams
    {
        public Task<IList<Team>> GetAllTeams();

    }
}
