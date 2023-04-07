using Newtonsoft.Json;
using SoccerDAL.AllRepos.TeamsResultsRepo;
using SoccerDAL.Errors;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.WomenRepos.WomenTeamsResults
{
    internal class WomenTeamsResultsRepo : IRepoTeamsResults
    {
        private readonly string _apiGetTeamsResults = "https://worldcup-vua.nullbit.hr/women/teams/results";
        private readonly HttpClient _client;

        public WomenTeamsResultsRepo(HttpClient client)
        {
            _client = client;
        }

        public async Task<IList<TeamResults>> GetTeamsResults()
        {
            try
            {
                using var response = await _client.GetAsync(_apiGetTeamsResults);
                await ApiErrorHandler.HandleErrorAsync(response);
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IList<TeamResults>>(json) ?? new List<TeamResults>();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while reading data from API: {ex.Message}");
            }

            string dataFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "JsonFiles");
            string jsonFilePath = Path.Combine(dataFolderPath, "WomenResults.json");

            try
            {
                string json = File.ReadAllText(jsonFilePath);
                return JsonConvert.DeserializeObject<IList<TeamResults>>(json) ?? new List<TeamResults>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while reading data from local JSON file: {ex.Message}");
            }

            return new List<TeamResults>();
        }
    }
}
