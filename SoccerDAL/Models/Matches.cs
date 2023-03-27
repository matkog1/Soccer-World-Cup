using Newtonsoft.Json;
using System;
using System.Reflection;
using System.Text;

namespace SoccerDAL.Models
{
    public class Matches
    {
        public Matches(string venue, string location, string status, string time, string fifa_id, Weather weather, string attendance, string[] officials, string stage_name, string home_team_country, string away_team_country, DateTime datetime, string winner, string winner_code, Home_Team home_team, Away_Team away_team, Home_Team_Events[] home_team_events, Away_Team_Events[] away_team_events, Home_Team_Statistics home_team_statistics, Away_Team_Statistics away_team_statistics, DateTime last_event_update_at, DateTime? last_score_update_at)
        {
            this.venue = venue;
            this.location = location;
            this.status = status;
            this.time = time;
            this.fifa_id = fifa_id;
            this.weather = weather;
            this.attendance = attendance;
            this.officials = officials;
            this.stage_name = stage_name;
            this.home_team_country = home_team_country;
            this.away_team_country = away_team_country;
            this.datetime = datetime;
            this.winner = winner;
            this.winner_code = winner_code;
            this.home_team = home_team;
            this.away_team = away_team;
            this.home_team_events = home_team_events;
            this.away_team_events = away_team_events;
            this.home_team_statistics = home_team_statistics;
            this.away_team_statistics = away_team_statistics;
            this.last_event_update_at = last_event_update_at;
            this.last_score_update_at = last_score_update_at;
        }

        [JsonProperty(PropertyName = "venue")]
        public string venue { get; set; }
        [JsonProperty(PropertyName = "location")]
        public string location { get; set; }
        [JsonProperty(PropertyName = "status")]
        public string status { get; set; }
        [JsonProperty(PropertyName = "time")]
        public string time { get; set; }
        [JsonProperty(PropertyName = "fifa_id")]
        public string fifa_id { get; set; }
        [JsonProperty(PropertyName = "weather")]
        public Weather weather { get; set; }
        [JsonProperty(PropertyName = "attendance")]
        public string attendance { get; set; }
        [JsonProperty(PropertyName = "officials")]
        public string[] officials { get; set; }
        [JsonProperty(PropertyName = "stage_name")]
        public string stage_name { get; set; }
        [JsonProperty(PropertyName = "home_team_country")]
        public string home_team_country { get; set; }
        [JsonProperty(PropertyName = "away_team_country")]
        public string away_team_country { get; set; }
        [JsonProperty(PropertyName = "datetime")]
        public DateTime datetime { get; set; }
        [JsonProperty(PropertyName = "winner")]
        public string winner { get; set; }
        [JsonProperty(PropertyName = "winner_code")]
        public string winner_code { get; set; }
        [JsonProperty(PropertyName = "home_team")]
        public Home_Team home_team { get; set; }
        [JsonProperty(PropertyName = "away_team")]
        public Away_Team away_team { get; set; }
        [JsonProperty(PropertyName = "home_team_events")]
        public Home_Team_Events[] home_team_events { get; set; }
        [JsonProperty(PropertyName = "away_team_events")]
        public Away_Team_Events[] away_team_events { get; set; }
        [JsonProperty(PropertyName = "home_team_statistics")]
        public Home_Team_Statistics home_team_statistics { get; set; }
        [JsonProperty(PropertyName = "away_team_statistics")]
        public Away_Team_Statistics away_team_statistics { get; set; }
        [JsonProperty(PropertyName = "last_event_update_at")]
        public DateTime last_event_update_at { get; set; }
        [JsonProperty(PropertyName = "last_score_update_at")]
        public DateTime? last_score_update_at { get; set; }

        public override string ToString()
        {

            var sb = new StringBuilder();
            sb.AppendLine($"Venue: {venue}");
            sb.AppendLine($"Location: {location}");
            sb.AppendLine($"Status: {status}");
            sb.AppendLine($"Time: {time}");
            sb.AppendLine($"FIFA ID: {fifa_id}");
            sb.AppendLine($"Attendance: {attendance}");
            sb.AppendLine($"Officials: {string.Join(", ", officials)}");
            sb.AppendLine($"Stage Name: {stage_name}");
            sb.AppendLine($"Home Team Country: {home_team_country}");
            sb.AppendLine($"Away Team Country: {away_team_country}");
            sb.AppendLine($"Datetime: {datetime}");
            sb.AppendLine($"Winner: {winner}");
            sb.AppendLine($"Winner Code: {winner_code}");
            sb.AppendLine($"Last Event Update At: {last_event_update_at}");
            sb.AppendLine($"Last Score Update At: {last_score_update_at}");
            sb.AppendLine($"Weather:\n{weather}");
            sb.AppendLine($"Home Team:\n{home_team}");
            sb.AppendLine($"Away Team:\n{away_team}");
            sb.AppendLine($"Home Team Events:\n{string.Join(",\n", home_team_events.Select(e => e.ToString()))}");
            sb.AppendLine($"Away Team Events:\n{string.Join(",\n", away_team_events.Select(e => e.ToString()))}");
            sb.AppendLine($"Home Team Statistics:\n{home_team_statistics}");
            sb.AppendLine($"Away Team Statistics:\n{away_team_statistics}");
            return sb.ToString();
        }

    }
}
