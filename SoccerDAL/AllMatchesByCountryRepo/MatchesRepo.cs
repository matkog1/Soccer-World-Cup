using Newtonsoft.Json;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllMatchesByCountryRepo
{
    internal class MatchesRepo : IRepoAllMatchesByCountry
    {
        private const string apiGetMatchesForCountry = "https://worldcup-vua.nullbit.hr/men/matches/country?fifa_code=";
        private HttpClient _client = new HttpClient();
        IList<Matches> teams = new List<Matches>();

        public async Task<IList<Matches>> MatchesByCountry(string fifa_code)
        {
         var response = await _client.GetStringAsync(apiGetMatchesForCountry + fifa_code);
         teams = JsonConvert.DeserializeObject<IList<Matches>>(response);
         return teams;
        }
    }
}
