using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using SoccerDAL.Models;

namespace SoccerDAL.Utility
{
    public class ApiRequests
    {
        private const string apiUrlGetTeamsResults = "https://worldcup-vua.nullbit.hr/men/teams/results";
        private const string apiUrlGetTeams = "https://worldcup-vua.nullbit.hr/men/teams";
        private const string apiUrlGetGroupResults = "https://worldcup-vua.nullbit.hr/men/teams/group_results";

        public async Task<IList<TeamResults>> GetAllMatchesAsync()
        {

            HttpClient _client = new HttpClient();
            IList<TeamResults> teamResults = new List<TeamResults>();
            var response = await _client.GetStringAsync(apiUrlGetTeamsResults);
            teamResults = JsonConvert.DeserializeObject<IList<TeamResults>>(response);
            return teamResults;
        }


        public async Task<IList<Team>> GetAllTeams()
        {
            HttpClient _client = new HttpClient();
            IList<Team> teams = new List<Team>();
            var response = await _client.GetStringAsync(apiUrlGetTeams);
            teams = JsonConvert.DeserializeObject<IList<Team>>(response);
            return teams;
        }

        public async Task<IList<Group>> GetGroupResults()
        {
            HttpClient _client = new HttpClient();
            IList<Group> teams = new List<Group>();
            var response = await _client.GetStringAsync(apiUrlGetGroupResults);
            teams = JsonConvert.DeserializeObject<IList<Group>>(response);
            return teams;
        }

    }
}
