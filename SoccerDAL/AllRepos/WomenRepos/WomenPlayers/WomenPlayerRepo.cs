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
        private static List<Player> CreatePlayersFromJson(List<JObject>? playerDataList, string country)
        {
            List<Player> players = new List<Player>();

            foreach (JObject playerData in playerDataList)
            {
                string name = (string)playerData.SelectToken("name");
                bool captain = (bool)playerData.SelectToken("captain");
                int shirt_number = (int)playerData.SelectToken("shirt_number");
                string position = (string)playerData.SelectToken("position");

                Player player = new Player(name, captain, shirt_number, position, country);
                players.Add(player);
            }

            return players;
        }

        public List<Player> GetPlayersFromJsonFile()
        {
            string filePath = @"C:\Users\matko\source\repos\matkog1\Soccer-World-Cup\SoccerDAL\JsonFiles\men\matches.json";
            // Read the JSON data from a file
            string jsonData = File.ReadAllText(filePath);

            // Parse the JSON data
            JArray matches = JArray.Parse(jsonData);

            // Extract the players from each match
            List<Player> players = new List<Player>();
            foreach (JObject match in matches)
            {
                // Get the home and away team data
                JObject homeTeam = (JObject)match.SelectToken("home_team_statistics");
                JObject awayTeam = (JObject)match.SelectToken("away_team_statistics");

                // Get the starting eleven and substitutes for each team
                List<JObject>? homePlayers = (homeTeam["starting_eleven"] ?? Enumerable.Empty<JToken>()).Concat(homeTeam["substitutes"] ?? Enumerable.Empty<JToken>()).Select(p => (JObject)p).ToList();
                List<JObject>? awayPlayers = (awayTeam["starting_eleven"] ?? Enumerable.Empty<JToken>()).Concat(awayTeam["substitutes"] ?? Enumerable.Empty<JToken>()).Select(p => (JObject)p).ToList();

                // Create player objects for each team player and add to list
                players.AddRange(CreatePlayersFromJson(homePlayers, homeTeam["team"]?["name"]?.ToString()!));
                players.AddRange(CreatePlayersFromJson(awayPlayers, awayTeam["team"]?["name"]?.ToString()!));
            }

            return players;
        }
    }
}
