﻿using Newtonsoft.Json;
using System.Reflection;
using System.Text;

namespace SoccerDAL.Models
{
    public class Home_Team_Statistics
    {
        public Home_Team_Statistics(string country, int? attempts_on_goal, int? on_target, int? off_target, int? blocked, int? woodwork, int? corners, int? offsides, int? ball_possession, int? pass_accuracy, int? num_passes, int? passes_completed, int? distance_covered, int? balls_recovered, int? tackles, int? clearances, int? yellow_cards, int? red_cards, int? fouls_committed, string tactics, Starting_Eleven[] starting_eleven, Substitute[] substitutes)
        {
            this.country = country;
            this.attempts_on_goal = attempts_on_goal ?? 0;
            this.on_target = on_target ?? 0;
            this.off_target = off_target ?? 0;
            this.blocked = blocked ?? 0;
            this.woodwork = woodwork ?? 0;
            this.corners = corners ?? 0;
            this.offsides = offsides ?? 0;
            this.ball_possession = ball_possession ?? 0;
            this.pass_accuracy = pass_accuracy ?? 0;
            this.num_passes = num_passes ?? 0;
            this.passes_completed = passes_completed ?? 0;
            this.distance_covered = distance_covered ?? 0;
            this.balls_recovered = balls_recovered ?? 0;
            this.tackles = tackles ?? 0;
            this.clearances = clearances ?? 0;
            this.yellow_cards = yellow_cards ?? 0;
            this.red_cards = red_cards ?? 0;
            this.fouls_committed = fouls_committed ?? 0;
            this.tactics = tactics ?? throw new ArgumentNullException(nameof(tactics));
            this.starting_eleven = starting_eleven ?? throw new ArgumentNullException(nameof(starting_eleven));
            this.substitutes = substitutes ?? throw new ArgumentNullException(nameof(substitutes));
        }

        [JsonProperty(PropertyName = "country")]
        public string country { get; set; }
        [JsonProperty(PropertyName = "attempts_on_goal")]
        public int? attempts_on_goal { get; set; }
        [JsonProperty(PropertyName = "on_target")]
        public int? on_target { get; set; }
        [JsonProperty(PropertyName = "off_target")]
        public int? off_target { get; set; }
        [JsonProperty(PropertyName = "blocked")]
        public int? blocked { get; set; }
        [JsonProperty(PropertyName = "woodwork")]
        public int? woodwork { get; set; }
        [JsonProperty(PropertyName = "corners")]
        public int? corners { get; set; }
        [JsonProperty(PropertyName = "offsides")]
        public int? offsides { get; set; }
        [JsonProperty(PropertyName = "ball_possession")]
        public int? ball_possession { get; set; }
        [JsonProperty(PropertyName = "pass_accuracy")]
        public int? pass_accuracy { get; set; }
        [JsonProperty(PropertyName = "num_passes")]
        public int? num_passes { get; set; }
        [JsonProperty(PropertyName = "passes_completed")]
        public int? passes_completed { get; set; }
        [JsonProperty(PropertyName = "distance_covered")]
        public int? distance_covered { get; set; }
        [JsonProperty(PropertyName = "balls_recovered")]
        public int? balls_recovered { get; set; }
        [JsonProperty(PropertyName = "tackles")]
        public int? tackles { get; set; }
        [JsonProperty(PropertyName = "clearances")]
        public int? clearances { get; set; }
        [JsonProperty(PropertyName = "yellow_cards")]
        public int? yellow_cards { get; set; }
        [JsonProperty(PropertyName = "red_cards")]
        public int? red_cards { get; set; }
        [JsonProperty(PropertyName = "fouls_com,otted")]
        public int? fouls_committed { get; set; }
        [JsonProperty(PropertyName = "tactics")]
        public string tactics { get; set; }
        [JsonProperty(PropertyName = "starting_eleven")]
        public Starting_Eleven[] starting_eleven { get; set; }
        [JsonProperty(PropertyName = "substitutes")]
        public Substitute[] substitutes { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Country: {country}");
            sb.AppendLine($"Attempts on Goal: {attempts_on_goal}");
            sb.AppendLine($"On Target: {on_target}");
            sb.AppendLine($"Off Target: {off_target}");
            sb.AppendLine($"Blocked: {blocked}");
            sb.AppendLine($"Woodwork: {woodwork}");
            sb.AppendLine($"Corners: {corners}");
            sb.AppendLine($"Offsides: {offsides}");
            sb.AppendLine($"Ball Possession: {ball_possession}%");
            sb.AppendLine($"Pass Accuracy: {pass_accuracy}%");
            sb.AppendLine($"Num Passes: {num_passes}");
            sb.AppendLine($"Passes Completed: {passes_completed}");
            sb.AppendLine($"Distance Covered: {distance_covered}m");
            sb.AppendLine($"Balls Recovered: {balls_recovered}");
            sb.AppendLine($"Tackles: {tackles}");
            sb.AppendLine($"Clearances: {clearances}");
            sb.AppendLine($"Yellow Cards: {yellow_cards}");
            sb.AppendLine($"Red Cards: {red_cards}");
            if (fouls_committed.HasValue)
            {
                sb.AppendLine($"Fouls Committed: {fouls_committed}");
            }
            sb.AppendLine($"Tactics: {tactics}");
            sb.AppendLine($"Starting Eleven:");
            foreach (var player in starting_eleven)
            {
                sb.AppendLine(player.ToString());
            }
            sb.AppendLine($"Substitutes:");
            foreach (var player in substitutes)
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString();
        }


    }
}
