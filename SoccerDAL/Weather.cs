using System.Reflection;

namespace SoccerDAL
{
    public class Weather
        {
            public string humidity { get; set; }
            public string temp_celsius { get; set; }
            public string temp_farenheit { get; set; }
            public string wind_speed { get; set; }
            public string description { get; set; }

        public override string ToString()
        {
            // napomena: refleksija radi na konzolu kroz ConsoleWriteline
            // za ostale klase postaviti isto
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
