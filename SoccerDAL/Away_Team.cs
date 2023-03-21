﻿using Newtonsoft.Json;
using System.Reflection;

namespace SoccerDAL
{
    public class Away_Team
        {
       
        [JsonProperty(PropertyName = "country")]
        public string country { get; set; }
        [JsonProperty(PropertyName = "code")]
        public string code { get; set; }
        [JsonProperty(PropertyName = "goals")]
        public int goals { get; set; }
        [JsonProperty(PropertyName = "penalties")]
        public int penalties { get; set; }

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
