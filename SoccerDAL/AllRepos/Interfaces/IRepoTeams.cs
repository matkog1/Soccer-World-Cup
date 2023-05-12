using Newtonsoft.Json;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.Interfaces
{
    public interface IRepoTeams
    {
        Task<IList<Team>> GetAllTeams();

    }
}
