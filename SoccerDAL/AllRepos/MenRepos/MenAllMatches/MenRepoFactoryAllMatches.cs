﻿using SoccerDAL.AllRepos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.MenRepos.MenAllMatches
{
    public static class MenRepoFactoryAllMatches
    {
        public static IRepoAllMatches GetRepo() => new AllMatchesRepoMen(new HttpClient());
    }
}
