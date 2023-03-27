using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.TeamsResultsRepo
{
    public static class RepoFactoryTeamsResults
    {
        public static IRepoTeamsResults GetRepo() => new TeamsResultsRepo(new HttpClient());
    }
}
