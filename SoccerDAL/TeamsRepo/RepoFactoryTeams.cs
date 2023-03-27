using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.TeamsRepo
{
    public static class RepoFactoryTeams
    {
        public static IRepoTeams GetTeams() => new TeamsRepo();
    }
}
