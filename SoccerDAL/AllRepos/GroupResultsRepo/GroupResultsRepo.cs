using Newtonsoft.Json;
using SoccerDAL.Errors;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.GroupResultsRepo
{
    internal class GroupResultsRepo : IRepoGroupResults
    {
        private readonly string _apiGetGroupResults = "https://worldcup-vua.nullbit.hr/men/teams/group_results";
        private readonly HttpClient _client;
        private IList<Group>? _groupResults = new List<Group>();

        public GroupResultsRepo(HttpClient client)
        {
            _client = client;
        }

        public async Task<IList<Group>> GetGroupResults()
        {
            try
            {
                using var response = await _client.GetAsync(_apiGetGroupResults);
                await ApiErrorHandler.HandleErrorAsync(response);
                var json = await response.Content.ReadAsStringAsync();
                _groupResults = JsonConvert.DeserializeObject<IList<Group>>(json);
                return _groupResults ?? new List<Group>();

            }
            catch (Exception ex)
            {

                await Console.Out.WriteLineAsync($"Error occured: {ex.Message}");
                throw;
            }

            finally { _client.Dispose(); }
        }
    }
}
