using System.Reflection;

namespace SoccerDAL
{
    public class Starting_Eleven
        {
            public string name { get; set; }
            public bool captain { get; set; }
            public int shirt_number { get; set; }
            public string position { get; set; }

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
