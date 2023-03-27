using Newtonsoft.Json;
using System.Reflection;

namespace SoccerDAL.Models
{
    public class Ordered_Teams : IComparable<Ordered_Teams>
    {
        public Ordered_Teams(int id, string country, object alternate_name, string fifa_code, int group_id, string group_letter, int wins, int draws, int losses, int games_played, int points, int goals_for, int goals_against, int goal_differential)
        {
            this.id = id;
            this.country = country;
            this.alternate_name = alternate_name;
            this.fifa_code = fifa_code;
            this.group_id = group_id;
            this.group_letter = group_letter;
            this.wins = wins;
            this.draws = draws;
            this.losses = losses;
            this.games_played = games_played;
            this.points = points;
            this.goals_for = goals_for;
            this.goals_against = goals_against;
            this.goal_differential = goal_differential;
        }

        [JsonProperty(PropertyName = "id")]
        public int id { get; set; }
        [JsonProperty(PropertyName = "country")]
        public string country { get; set; }
        [JsonProperty(PropertyName = "alternate_name")]
        public object alternate_name { get; set; }
        [JsonProperty(PropertyName = "fifa_code")]
        public string fifa_code { get; set; }
        [JsonProperty(PropertyName = "group_id")]
        public int group_id { get; set; }

        [JsonProperty(PropertyName = "group_letter")]
        public string group_letter { get; set; }
        [JsonProperty(PropertyName = "wins")]
        public int wins { get; set; }
        [JsonProperty(PropertyName = "draws")]
        public int draws { get; set; }
        [JsonProperty(PropertyName = "losses")]
        public int losses { get; set; }
        [JsonProperty(PropertyName = "games_played")]
        public int games_played { get; set; }
        [JsonProperty(PropertyName = "points")]
        public int points { get; set; }
        [JsonProperty(PropertyName = "goals_for")]
        public int goals_for { get; set; }

        [JsonProperty(PropertyName = "goals_against")]
        public int goals_against { get; set; }

        [JsonProperty(PropertyName = "goal_differential")]
        public int goal_differential { get; set; }

        public int CompareTo(Ordered_Teams? other) => id.CompareTo(other.id);

        public override bool Equals(object? obj)
        {
            return obj is Ordered_Teams teams &&
                   id == teams.id &&
                   country == teams.country;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, country);
        }

        public override string ToString()
        {

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
