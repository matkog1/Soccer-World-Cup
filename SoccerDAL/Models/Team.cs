using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.Models
{
    public class Team : IComparable<Team>
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

        public int CompareTo(Team? other) => id.CompareTo(other.id);

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
