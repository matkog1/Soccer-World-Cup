using Newtonsoft.Json;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.Interfaces
{
    public interface IRepoAllMatchesByCountry
    {
        Task<IList<Matches>> MatchesByCountry(string fifa_code);

    }
}
