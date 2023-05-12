using SoccerDAL.AllRepos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.MenRepos.MenTeamsResults
{
    public static class MenRepoFactoryTeamsResults
    {
        public static IRepoTeamsResults GetRepo() => new MenTeamsResultsRepo(new HttpClient());
    }
}
