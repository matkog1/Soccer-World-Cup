﻿using System;
using System.Reflection;

namespace SoccerDAL.Models
{
    public class Matches
    {

        public string venue { get; set; }
        public string location { get; set; }
        public string status { get; set; }
        public string time { get; set; }
        public string fifa_id { get; set; }
        public Weather weather { get; set; }
        public string attendance { get; set; }
        public string[] officials { get; set; }
        public string stage_name { get; set; }
        public string home_team_country { get; set; }
        public string away_team_country { get; set; }
        public DateTime datetime { get; set; }
        public string winner { get; set; }
        public string winner_code { get; set; }
        public Home_Team home_team { get; set; }
        public Away_Team away_team { get; set; }
        public Home_Team_Events[] home_team_events { get; set; }
        public Away_Team_Events[] away_team_events { get; set; }
        public Home_Team_Statistics home_team_statistics { get; set; }
        public Away_Team_Statistics away_team_statistics { get; set; }
        public DateTime last_event_update_at { get; set; }
        public DateTime? last_score_update_at { get; set; }

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
