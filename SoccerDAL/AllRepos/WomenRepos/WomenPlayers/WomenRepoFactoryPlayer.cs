using SoccerDAL.AllRepos.PlayerRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.WomenRepos.WomenPlayers
{
    public static class WomenRepoFactoryPlayer
    {
        public static IRepoPlayer GetRepo() => new WomenPlayerRepo();
    }
}
