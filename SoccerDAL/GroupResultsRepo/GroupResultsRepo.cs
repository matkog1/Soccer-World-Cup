using Newtonsoft.Json;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.GroupResultsRepo
{
    internal class GroupResultsRepo : IRepoGroupResults
    {
        private const string apiGetGroupResults = "https://worldcup-vua.nullbit.hr/men/teams/group_results";
        HttpClient _client = new HttpClient();
        IList<Group> teams = new List<Group>();

        public async Task<IList<Group>> GetGroupResults()
        {
            var response = await _client.GetStringAsync(apiGetGroupResults);
            teams = JsonConvert.DeserializeObject<IList<Group>>(response);
            return teams;
        }
    }
}
