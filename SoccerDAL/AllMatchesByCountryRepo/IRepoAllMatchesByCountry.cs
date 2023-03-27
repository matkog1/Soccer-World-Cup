using Newtonsoft.Json;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllMatchesByCountryRepo
{
    public interface IRepoAllMatchesByCountry
    {
        public Task<IList<Matches>> MatchesByCountry(string fifa_code);
        
    }
}
