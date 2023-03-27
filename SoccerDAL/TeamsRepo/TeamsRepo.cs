using Newtonsoft.Json;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.TeamsRepo
{
    internal class TeamsRepo : IRepoTeams
    {
        private const string apiGetTeams = "https://worldcup-vua.nullbit.hr/men/teams";
        private HttpClient _client = new HttpClient();
        public async Task<IList<Team>> GetAllTeams()
        {
            IList<Team> teams = new List<Team>();
            var response = await _client.GetStringAsync(apiGetTeams);
            teams = JsonConvert.DeserializeObject<IList<Team>>(response);
            return teams;
        }
    }
}
