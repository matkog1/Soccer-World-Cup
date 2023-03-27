using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.Models
{

    public class Group
    {
        public Group(int id, string letter, IList<Ordered_Teams> ordered_teams)
        {
            this.id = id;
            this.letter = letter;
            this.ordered_teams = ordered_teams;
        }

        [JsonProperty(PropertyName = "id")]
        public int id { get; set; }
        [JsonProperty(PropertyName = "letter")]
        public string letter { get; set; }
        [JsonProperty(PropertyName = "ordered_teams")]
        public IList<Ordered_Teams> ordered_teams { get; set; }

        public override string ToString()
        {

            string result = $"Group {letter.ToUpper()}\n";
            foreach (var team in ordered_teams)
            {
                result += $"{team}\n";
            }
            return result;
        }
    }

}
