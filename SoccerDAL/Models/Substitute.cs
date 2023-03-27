using Newtonsoft.Json;
using System.Reflection;

namespace SoccerDAL.Models
{
    public class Substitute
    {
        public Substitute(string name, bool captain, int shirt_number, string position)
        {
            this.name = name;
            this.captain = captain;
            this.shirt_number = shirt_number;
            this.position = position;
        }
        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }
        [JsonProperty(PropertyName = "captain")]
        public bool captain { get; set; }
        [JsonProperty(PropertyName = "shirt_number")]
        public int shirt_number { get; set; }
        [JsonProperty(PropertyName = "position")]
        public string position { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Substitute substitute &&
                   name == substitute.name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name);
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
