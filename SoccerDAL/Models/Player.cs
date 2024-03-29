﻿using Newtonsoft.Json;
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
        public Player()
        {
        }

        public Player(string name, bool captain, int shirt_number, string position, string country)
        {
            Name = name;
            Captain = captain;
            Shirt_Number = shirt_number;
            Position = position;
            Country = country;
        }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "captain")]
        public bool Captain { get; set; }
        [JsonProperty(PropertyName = "s hirt_Number")]
        public int Shirt_Number { get; set; }
        [JsonProperty(PropertyName = "position")]
        public string Position { get; set; }
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        public bool Favorite  { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Player player &&
                   Name == player.Name &&
                   Captain == player.Captain &&
                   Shirt_Number == player.Shirt_Number &&
                   Position == player.Position &&
                   Country == player.Country &&
                   Favorite == player.Favorite;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Captain, Shirt_Number, Position, Country, Favorite);
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
