using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.TeamsResultsRepo
{
    public interface IRepoTeamsResults
    {
       Task<IList<TeamResults>> GetTeamsResults();
    }
}
