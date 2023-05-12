using SoccerDAL.AllRepos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.WomenRepos.WomenAllMatches
{
    public static class WomenRepoFactoryAllMatches
    {
        public static IRepoAllMatches GetRepo() => new AllMatchesRepoWomen(new HttpClient());
    }
}
