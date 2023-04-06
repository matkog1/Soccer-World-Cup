using SoccerDAL.AllRepos.TeamsRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.WomenRepos.WomenTeams
{
    public static class WomenRepoFactoryTeams
    {
        public static IRepoTeams GetRepo() => new WomenTeamsRepo(new HttpClient());
    }
}
