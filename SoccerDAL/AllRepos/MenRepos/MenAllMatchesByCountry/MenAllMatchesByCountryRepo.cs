using Newtonsoft.Json;
using SoccerDAL.Errors;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoccerDAL.AllRepos.Interfaces;

namespace SoccerDAL.AllRepos.MenRepos.MenAllMatchesByCountry
{
    internal class MenAllMatchesByCountryRepo : IRepoAllMatchesByCountry
    {
        private readonly string _apiGetMatchesForCountry = "https://worldcup-vua.nullbit.hr/men/matches/country?fifa_code=";
        private readonly HttpClient _client;

        public MenAllMatchesByCountryRepo(HttpClient client)
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
                return JsonConvert.DeserializeObject<IList<Matches>>(json) ?? new List<Matches>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while reading data from API: {ex.Message}");
            }

            string dataFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "JsonFiles");
            string jsonFilePath = Path.Combine(dataFolderPath, "MenMatches.json");

            try
            {
                string json = File.ReadAllText(jsonFilePath);
                var allMatches = JsonConvert.DeserializeObject<IList<Matches>>(json) ?? new List<Matches>();
                var matchesForTeam = allMatches.Where(m => m.home_team.code == fifa_code || m.away_team.code == fifa_code).ToList();
                return matchesForTeam;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while reading data from local JSON file: {ex.Message}");
            }

            return new List<Matches>();

        }
    }
}
