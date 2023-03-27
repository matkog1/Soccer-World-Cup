using Newtonsoft.Json;
using System.Reflection;

namespace SoccerDAL.Models
{
    public class Away_Team_Events
    {
        public Away_Team_Events(int id, string type_of_event, string player, string time)
        {
            this.id = id;
            this.type_of_event = type_of_event ?? throw new ArgumentNullException(nameof(type_of_event));
            this.player = player ?? throw new ArgumentNullException(nameof(player));
            this.time = time ?? throw new ArgumentNullException(nameof(time));
        }

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
