using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.Repo
{
    public static class RepoFactoryMatches
    {
        public static IRepoAllMatches GetRepo() => new MatchesRepo();
    }
}
