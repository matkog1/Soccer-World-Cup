using Newtonsoft.Json;
using SoccerDAL.Errors;
using SoccerDAL.Models;
using SoccerDAL.AllRepos.AllMatchesByCountryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.AllMatchesByCountryRepo
{
    internal class AllMatchesByCountryRepo : IRepoAllMatchesByCountry
    {
        private readonly string _apiGetMatchesForCountry = "https://worldcup-vua.nullbit.hr/men/matches/country?fifa_code=";
        private readonly HttpClient _client;
        private IList<Matches>? _matchesByTeams = new List<Matches>();

        public AllMatchesByCountryRepo(HttpClient client)
        {
            _client = client;
        }

        public async Task<IList<Matches>> MatchesByCountry(string fifa_code)
        {
            try
            {
                using var response = await _client.GetAsync(_apiGetMatchesForCountry + fifa_code);
                await ApiErrorHandler.HandleErrorAsync(response);
                var json = await response.Content.ReadAsStringAsync();
                _matchesByTeams = JsonConvert.DeserializeObject<IList<Matches>>(json);
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
