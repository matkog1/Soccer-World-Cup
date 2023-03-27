using Newtonsoft.Json;
using System.Reflection;

namespace SoccerDAL.Models
{
    public class Away_Team
    {
        public Away_Team(string country, string code, int goals, int penalties)
        {
            this.country = country;
            this.code = code;
            this.goals = goals;
            this.penalties = penalties;
        }

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
