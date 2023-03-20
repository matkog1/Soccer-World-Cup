using System.Reflection;

namespace SoccerDAL
{
    public class Home_Team_Events
        {
            public int id { get; set; }
            public string type_of_event { get; set; }
            public string player { get; set; }
            public string time { get; set; }

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
