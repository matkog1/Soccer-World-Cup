using Newtonsoft.Json;
using SoccerDAL.AllRepos.Interfaces;
using SoccerDAL.Errors;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.WomenRepos.WomenAllMatches
{
    internal class AllMatchesRepoWomen : IRepoAllMatches
    {
        private readonly string _apiGetMatches = "https://worldcup-vua.nullbit.hr/women/matches";
        private readonly HttpClient _client;

        public AllMatchesRepoWomen(HttpClient client)
        {
            _client = client;
        }

        public async Task<IList<Matches>> GetAllMatches()
        {
            try
            {
                using var response = await _client.GetAsync(_apiGetMatches);
                await ApiErrorHandler.HandleErrorAsync(response);
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IList<Matches>>(json) ?? new List<Matches>();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while reading data from API: {ex.Message}");
            }

            string dataFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "JsonFiles");
            string jsonFilePath = Path.Combine(dataFolderPath, "WomenMatches.json");

            try
            {

                string json = File.ReadAllText(jsonFilePath);
                return JsonConvert.DeserializeObject<IList<Matches>>(json) ?? new List<Matches>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while reading data from local JSON file: {ex.Message}");
            }

            return new List<Matches>();
        }

    }
}
