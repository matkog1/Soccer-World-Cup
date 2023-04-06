using Newtonsoft.Json;
using SoccerDAL.Errors;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.TeamsRepo
{
    internal class MenTeamsRepo : IRepoTeams
    {
        private readonly string _apiGetTeams = "https://worldcup-vua.nullbit.hr/men/teams";
        private readonly HttpClient _client;
        private IList<Team>? _teams = new List<Team>();

        public MenTeamsRepo(HttpClient httpClient)
        {
            _client = httpClient;
        }


        public async Task<IList<Team>> GetAllTeams()
        {

            try
            {
                using var response = await _client.GetAsync(_apiGetTeams);
                await ApiErrorHandler.HandleErrorAsync(response);
                var json = await response.Content.ReadAsStringAsync();
                _teams = JsonConvert.DeserializeObject<IList<Team>>(json);
                return _teams ?? new List<Team>();

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
