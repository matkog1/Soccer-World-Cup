using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class UserRepository : IUserRepository
    {
        private readonly string credentialsFile;

        public UserRepository(string credentialsFile)
        {
            this.credentialsFile = credentialsFile;
        }

        public void AddUser(User user)
        {
            string credentials = $"{user.Username}:{user.Password}";
            File.AppendAllText(credentialsFile, $"{Environment.NewLine}{credentials}");
        }

        public User GetUserByUsername(string username)
        {
            string[] credentials = File.ReadAllLines(credentialsFile);
            foreach (string credential in credentials)
            {
                string[] credentialArray = credential.Split(':');
                if (credentialArray[0] == username)
                {
                    return new User { Username = credentialArray[0], Password = credentialArray[1] };
                }
            }
            return null;
        }
    }
}
