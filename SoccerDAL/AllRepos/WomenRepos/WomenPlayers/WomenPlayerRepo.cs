using Newtonsoft.Json.Linq;
using SoccerDAL.AllRepos.PlayerRepo;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.WomenRepos.WomenPlayers
{
    internal class WomenPlayerRepo : IRepoPlayer
    {
        private static List<Player> CreatePlayersFromJson(List<JObject>? playerDataList)
        {
            List<Player> players = new List<Player>();

            foreach (JObject playerData in playerDataList)
            {
                string name = (string)playerData.SelectToken("name");
                bool captain = (bool)playerData.SelectToken("captain");
                int shirt_number = (int)playerData.SelectToken("shirt_number");
                string position = (string)playerData.SelectToken("position");
                string country = (string)playerData.SelectToken("country");

                Player player = new Player(name, captain, shirt_number, position, country);
                players.Add(player);
            }

            return players;
        }

        public Dictionary<string, List<Player>> GetPlayersByCountryFromJsonFile()
        {
            HashSet<Player> players = GetPlayersFromJsonFile();

            // Group the players by country and create the dictionary
            Dictionary<string, List<Player>> playersByCountry = players.GroupBy(p => p.Country)
                .ToDictionary(g => g.Key, g => g.ToList());

            return playersByCountry;
        }

        public HashSet<Player> GetPlayersFromJsonFile()
        {
            string dataFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "JsonFiles");
            string jsonFilePath = Path.Combine(dataFolderPath, "WomenMatches.json");

            // Read the JSON data from a file
            string jsonData = File.ReadAllText(jsonFilePath);

            // Parse the JSON data
            JArray matches = JArray.Parse(jsonData);

            // Extract the players from each match
            HashSet<Player> players = new HashSet<Player>();
            foreach (JObject match in matches)
            {
                // Get the home and away team data
                JObject homeTeam = (JObject)match.SelectToken("home_team_statistics");
                JObject awayTeam = (JObject)match.SelectToken("away_team_statistics");

                // Get the starting eleven and substitutes for each team
                List<JObject>? homePlayers = (homeTeam["starting_eleven"] ?? Enumerable.Empty<JToken>()).Concat(homeTeam["substitutes"] ?? Enumerable.Empty<JToken>()).Select(p => (JObject)p).ToList();
                List<JObject>? awayPlayers = (awayTeam["starting_eleven"] ?? Enumerable.Empty<JToken>()).Concat(awayTeam["substitutes"] ?? Enumerable.Empty<JToken>()).Select(p => (JObject)p).ToList();

                // Add the country information to each player
                foreach (JObject player in homePlayers)
                {
                    player["country"] = homeTeam["country"]?.ToString()!;
                }

                foreach (JObject player in awayPlayers)
                {
                    player["country"] = awayTeam["country"]?.ToString()!;
                }

                // Create player objects for each team player and add to list
                players.UnionWith(CreatePlayersFromJson(homePlayers));
                players.UnionWith(CreatePlayersFromJson(awayPlayers));
            }

            return players;
        }
    }

}
