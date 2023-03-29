using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.PlayerRepo
{
    public static class RepoFactoryPlayer
    {
        public static IRepoPlayer GetRepo() => new PlayerRepo();
    }
}
