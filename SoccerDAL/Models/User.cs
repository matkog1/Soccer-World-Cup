using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   Username == user.Username &&
                   Password == user.Password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Username, Password);
        }

        public override string ToString() => $"{Username} {Password}";  
    }
}
