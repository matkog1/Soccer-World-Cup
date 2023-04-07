using Newtonsoft.Json;
using SoccerDAL.Errors;
using SoccerDAL.Models;
using System;
using System.IO;
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
                return JsonConvert.DeserializeObject<IList<Team>>(json) ?? new List<Team>();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while reading data from API: {ex.Message}");
            }

            string dataFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "JsonFiles");
            string jsonFilePath = Path.Combine(dataFolderPath, "MenTeams.json");

            try
            {
                string json = File.ReadAllText(jsonFilePath);
                return JsonConvert.DeserializeObject<IList<Team>>(json) ?? new List<Team>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while reading data from local JSON file: {ex.Message}");
            }

            return new List<Team>();
        }
    }

}
