using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.TeamsRepo
{
    public static class MenRepoFactoryTeams
    {
        public static IRepoTeams GetRepo() => new MenTeamsRepo(new HttpClient());
    }
}
