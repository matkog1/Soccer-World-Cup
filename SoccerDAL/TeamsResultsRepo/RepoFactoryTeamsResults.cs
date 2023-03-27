using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.TeamsResultsRepo
{
    public static class RepoFactoryTeamsResults
    {
        public static IRepoTeamsResults GetRepo() => new TeamsResultsRepo();
    }
}
