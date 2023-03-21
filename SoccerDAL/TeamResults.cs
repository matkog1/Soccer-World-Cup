using Newtonsoft.Json;
using System.Reflection;

namespace SoccerDAL
{
    public class TeamResults : Team
    {
        public TeamResults(int id, string country, string alternate_name, string fifa_code, int group_id, string group_letter, int wins, int draws, int losses, int games_played, int points, int goals_for, int goals_against, int goal_differential) : base(id, country, alternate_name, fifa_code, group_id, group_letter)
        {
            this.wins = wins;
            this.draws = draws;
            this.losses = losses;
            this.games_played = games_played;
            this.points = points;
            this.goals_for = goals_for;
            this.goals_against = goals_against;
            this.goal_differential = goal_differential;
        }

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

        public override string ToString()
        {
           
            PropertyInfo[] properties = this.GetType().GetProperties();
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