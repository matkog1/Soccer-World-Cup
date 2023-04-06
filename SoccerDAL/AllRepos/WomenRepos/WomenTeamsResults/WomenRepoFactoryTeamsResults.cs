using SoccerDAL.AllRepos.TeamsResultsRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.WomenRepos.WomenTeamsResults
{
    public static class WomenRepoFactoryTeamsResults
    {
        public static IRepoTeamsResults GetRepo() => new WomenTeamsResultsRepo(new HttpClient());
    }
}
