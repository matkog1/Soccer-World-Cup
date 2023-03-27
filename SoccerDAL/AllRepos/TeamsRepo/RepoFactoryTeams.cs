using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.TeamsRepo
{
    public static class RepoFactoryTeams
    {
        public static IRepoTeams GetRepo() => new TeamsRepo(new HttpClient());
    }
}
