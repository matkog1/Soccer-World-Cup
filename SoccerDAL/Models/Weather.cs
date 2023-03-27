using Newtonsoft.Json;
using System.Reflection;

namespace SoccerDAL.Models
{
    public class Weather
    {
        public Weather(string humidity, string temp_celsius, string temp_farenheit, string wind_speed, string description)
        {
            this.humidity = humidity;
            this.temp_celsius = temp_celsius;
            this.temp_farenheit = temp_farenheit;
            this.wind_speed = wind_speed;
            this.description = description;
        }
        [JsonProperty(PropertyName = "humidity")]
        public string humidity { get; set; }
        [JsonProperty(PropertyName = "temp_celsius")]
        public string temp_celsius { get; set; }
        [JsonProperty(PropertyName = "temp_farenheit")]
        public string temp_farenheit { get; set; }
        [JsonProperty(PropertyName = "wind_speed")]
        public string wind_speed { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string description { get; set; }

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
