using Newtonsoft.Json;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.Repo
{
    internal class MatchesRepo : IRepoAllMatches
    {
        private const string apiGetAllMatches = "https://worldcup-vua.nullbit.hr/men/matches";
        private HttpClient _client = new HttpClient();
        private IList<Matches>? teamResults = new List<Matches>();

        public async Task<IList<Matches>> GetAllMatches()
        {

            var response = await _client.GetStringAsync(apiGetAllMatches);
            teamResults = JsonConvert.DeserializeObject<IList<Matches>>(response);
            return teamResults;

        }

    }
}
