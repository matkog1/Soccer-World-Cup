using Newtonsoft.Json;
using SoccerDAL.AllRepos.AllMatchesRepo;
using SoccerDAL.Errors;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.AllMatchesRepo
{
    internal class AllMatchesRepo : IRepoAllMatches
    {

        private readonly string _apiGetMatchesForCountry = "https://worldcup-vua.nullbit.hr/women/matches";
        private readonly HttpClient _client;
        private List<Matches>? _matchesByTeams = new List<Matches>();

        public AllMatchesRepo(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<Matches>> GetAllMatches()
        {
            try
            {
                using var response = await _client.GetAsync(_apiGetMatchesForCountry);
                await ApiErrorHandler.HandleErrorAsync(response);
                var json = await response.Content.ReadAsStringAsync();
                _matchesByTeams = JsonConvert.DeserializeObject<List<Matches>>(json);
                return _matchesByTeams ?? new List<Matches>();
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync($"Error occured: {ex.Message}");
                throw;
            }
            finally
            {
                _client.Dispose(); ;
            }
        }

    }
}








