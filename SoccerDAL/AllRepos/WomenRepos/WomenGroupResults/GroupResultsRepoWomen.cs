using Newtonsoft.Json;
using SoccerDAL.AllRepos.GroupResultsRepo;
using SoccerDAL.Errors;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.WomenRepos.WomenGroupResults
{
    internal class GroupResultsRepoWomen : IRepoGroupResults
    {
        private readonly string _apiGetGroupResults = "https://worldcup-vua.nullbit.hr/women/teams/group_results";
        private readonly HttpClient _client;

        public GroupResultsRepoWomen(HttpClient client)
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
                return JsonConvert.DeserializeObject<IList<Group>>(json) ?? new List<Group>();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while reading data from API: {ex.Message}");
            }

            string dataFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "JsonFiles");
            string jsonFilePath = Path.Combine(dataFolderPath, "WomenGroup_results.json");

            try
            {
                string json = File.ReadAllText(jsonFilePath);
                return JsonConvert.DeserializeObject<IList<Group>>(json) ?? new List<Group>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while reading data from local JSON file: {ex.Message}");
            }

            return new List<Group>();
        }
    }
}
