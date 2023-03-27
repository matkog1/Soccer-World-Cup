using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using SoccerDAL.Models;
using static System.Net.WebRequestMethods;

namespace SoccerDAL.Utility
{
    public class ApiRequests
    {
        private const string apiGetAllMatches = "https://worldcup-vua.nullbit.hr/men/matches";
        private const string apiGetMatchesForCountry = "https://worldcup-vua.nullbit.hr/men/matches/country?fifa_code=";
        private const string apiGetTeams = "https://worldcup-vua.nullbit.hr/men/teams";
        private const string apiGetTeamsResults = "https://worldcup-vua.nullbit.hr/men/teams/results";
        private const string apiGetGroupResults = "https://worldcup-vua.nullbit.hr/men/teams/group_results";

        public async Task<IList<TeamResults>> GetAllMatchesAsync()
        {

            HttpClient _client = new HttpClient();
            IList<TeamResults> teamResults = new List<TeamResults>();
            var response = await _client.GetStringAsync(apiGetTeamsResults);
            teamResults = JsonConvert.DeserializeObject<IList<TeamResults>>(response);
            return teamResults;
        }


        public async Task<IList<Team>> GetAllTeams()
        {
            HttpClient _client = new HttpClient();
            IList<Team> teams = new List<Team>();
            var response = await _client.GetStringAsync(apiGetTeams);
            teams = JsonConvert.DeserializeObject<IList<Team>>(response);
            return teams;
        }

        public async Task<IList<Group>> GetGroupResults()
        {
            HttpClient _client = new HttpClient();
            IList<Group> teams = new List<Group>();
            var response = await _client.GetStringAsync(apiGetGroupResults);
            teams = JsonConvert.DeserializeObject<IList<Group>>(response);
            return teams;
        }

        public async Task<IList<Matches>> MatchesByCountry(string fifa_code)
        {
            HttpClient _client = new HttpClient();
            IList<Matches> teams = new List<Matches>();
            var response = await _client.GetStringAsync(apiGetMatchesForCountry + $"{fifa_code}");
            teams = JsonConvert.DeserializeObject<IList<Matches>>(response);
            return teams;
        }

        public async Task<IList<Matches>> GetAllMatches()
        {

            HttpClient _client = new HttpClient();
            _client.Timeout = TimeSpan.FromSeconds(60);
            IList<Matches> teamResults = new List<Matches>();
            var response = await _client.GetStringAsync(apiGetAllMatches);
            teamResults = JsonConvert.DeserializeObject<IList<Matches>>(response);
            return teamResults;

        }

    }
}
