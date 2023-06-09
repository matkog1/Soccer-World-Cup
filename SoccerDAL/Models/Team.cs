﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.Models
{
    public class Team
    {
        public Team(int id, string country, string alternate_name, string fifa_code, int group_id, string group_letter)
        {
            this.id = id;
            this.country = country;
            this.alternate_name = alternate_name;
            this.fifa_code = fifa_code;
            this.group_id = group_id;
            this.group_letter = group_letter;
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

        

        public override bool Equals(object? obj)
        {
            return obj is Team team &&
                   id == team.id &&
                   fifa_code == team.fifa_code &&
                   group_id == team.group_id &&
                   group_letter == team.group_letter;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, fifa_code, group_id, group_letter);
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
