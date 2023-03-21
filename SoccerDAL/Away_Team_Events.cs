using Newtonsoft.Json;
using System.Reflection;

namespace SoccerDAL
{
    public class Away_Team_Events
        {
        [JsonProperty(PropertyName = "id")]
        public int id { get; set; }
        [JsonProperty(PropertyName = "type_of_event")]
        public string type_of_event { get; set; }
        [JsonProperty(PropertyName = "player")]
        public string player { get; set; }
        [JsonProperty(PropertyName = "time")]
        public string time { get; set; }

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
