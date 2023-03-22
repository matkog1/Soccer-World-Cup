using Newtonsoft.Json;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoccerDAL.Repo
{
    public interface IRepo
    {
        public  Task<IEnumerable<TeamResults>> GetAllMatchesAsync();
        public  Task<TeamResults> GetMatchByIdAsync(int id);

    }
}
