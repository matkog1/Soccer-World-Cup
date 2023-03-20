using System.Reflection;

namespace SoccerDAL
{
    public class Away_Team
        {
            public string country { get; set; }
            public string code { get; set; }
            public int goals { get; set; }
            public int penalties { get; set; }

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
