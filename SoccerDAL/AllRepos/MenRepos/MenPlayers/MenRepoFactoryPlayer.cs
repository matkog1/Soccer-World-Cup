﻿using SoccerDAL.AllRepos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.MenRepos.MenPlayers
{
    public static class MenRepoFactoryPlayer
    {
        public static IRepoPlayer GetRepo() => new MenPlayerRepo();
    }
}
