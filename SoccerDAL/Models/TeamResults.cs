using Newtonsoft.Json;
using System.Reflection;

namespace SoccerDAL.Models
{
    public class TeamResults : IComparable<TeamResults>
    {
        [JsonProperty(PropertyName = "id")]
        public int id { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string country { get; set; }

        [JsonProperty(PropertyName = "alternate_name")]
        public string alternate_name { get; set; }

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

        public int CompareTo(TeamResults? other) => id.CompareTo(other.id);

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