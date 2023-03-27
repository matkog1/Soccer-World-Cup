using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.GroupResultsRepo
{
    public interface IRepoGroupResults
    {
        public Task<IList<Group>> GetGroupResults();
    }
}
