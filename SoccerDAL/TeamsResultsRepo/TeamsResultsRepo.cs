using Newtonsoft.Json;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.TeamsResultsRepo
{
    internal class TeamsResultsRepo : IRepoTeamsResults
    {
        private const string apiGetTeamsResults = "https://worldcup-vua.nullbit.hr/men/teams/results";
       
        private HttpClient _client = new HttpClient();
        
        IList<TeamResults> teamResults = new List<TeamResults>();
        
        public async Task<IList<TeamResults>> GetTeamsResults()
        {
            var response = await _client.GetStringAsync(apiGetTeamsResults);
            teamResults = JsonConvert.DeserializeObject<IList<TeamResults>>(response);
            return teamResults;
        }
    }
}
