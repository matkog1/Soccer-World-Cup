using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.Models
{
    public class Player
    {
        public Player(string name, bool captain, int shirt_number, string position, string country)
        {
            Name = name;
            Captain = captain;
            Shirt_Number = shirt_number;
            Position = position;
            Country = country;
        }

        public string Name { get; set; }
        public bool Captain { get; set; }
        public int Shirt_Number { get; set; }
        public string Position { get; set; }
        public string Country { get; set; }

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
