using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.AllMatchesRepo
{
    public interface IRepoAllMatches
    {
        Task<List<Matches>> GetAllMatches();
    }
}
