using Newtonsoft.Json;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoccerDAL.Repo
{
    class TeamRepo : IRepo
    {
        public Task<IEnumerable<TeamResults>> GetAllMatchesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TeamResults> GetMatchByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
