using SoccerDAL.AllRepos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.MenRepos.MenTeams
{
    public static class MenRepoFactoryTeams
    {
        public static IRepoTeams GetRepo() => new MenTeamsRepo(new HttpClient());
    }
}
