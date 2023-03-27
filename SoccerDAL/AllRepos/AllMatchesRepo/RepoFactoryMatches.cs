using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.AllMatchesRepo
{
    public static class RepoFactoryMatches
    {
        public static IRepoAllMatches GetRepo() => new AllMatchesRepo(new HttpClient());
    }
}
