using Newtonsoft.Json;
using System.Reflection;

namespace SoccerDAL.Models
{
    public class TeamResults
    {
        public TeamResults(int? id, string country, string alternate_name, string fifa_code, int? group_id, string group_letter, int? wins, int? draws, int? losses, int? games_played, int? points, int? goals_for, int? goals_against, int? goal_differential)
        {
            this.id = id;
            this.country = country ?? throw new ArgumentNullException(nameof(country));
            this.alternate_name = alternate_name;
            this.fifa_code = fifa_code ?? throw new ArgumentNullException(nameof(fifa_code));
            this.group_id = group_id;
            this.group_letter = group_letter ?? throw new ArgumentNullException(nameof(group_letter));
            this.wins = wins ?? 0;
            this.draws = draws ?? 0;
            this.losses = losses ?? 0;
            this.games_played = games_played ?? 0;
            this.points = points ?? 0;
            this.goals_for = goals_for ?? 0;
            this.goals_against = goals_against ?? 0;
            this.goal_differential = goal_differential ?? 0;
        }

        [JsonProperty(PropertyName = "id")]
        public int? id { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string country { get; set; }

        [JsonProperty(PropertyName = "alternate_name")]
        public string alternate_name { get; set; }

        [JsonProperty(PropertyName = "fifa_code")]
        public string fifa_code { get; set; }

        [JsonProperty(PropertyName = "group_id")]
        public int? group_id { get; set; }

        [JsonProperty(PropertyName = "group_letter")]
        public string group_letter { get; set; }

        [JsonProperty(PropertyName = "wins")]
        public int? wins { get; set; }

        [JsonProperty(PropertyName = "draws")]
        public int? draws { get; set; }

        [JsonProperty(PropertyName = "losses")]
        public int? losses { get; set; }

        [JsonProperty(PropertyName = "games_played")]
        public int? games_played { get; set; }

        [JsonProperty(PropertyName = "points")]
        public int? points { get; set; }

        [JsonProperty(PropertyName = "goals_for")]
        public int? goals_for { get; set; }

        [JsonProperty(PropertyName = "goals_against")]
        public int? goals_against { get; set; }

        [JsonProperty(PropertyName = "goal_differential")]
        public int? goal_differential { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is TeamResults results &&
                   id == results.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }

        public override string ToString()
        {

            Console.WriteLine("");
            PropertyInfo[] properties = GetType().GetProperties();
            string result = "";

            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(this, null);
                result += $"{property.Name}: {value}\n";
            }
            return result;
        }

    }
}