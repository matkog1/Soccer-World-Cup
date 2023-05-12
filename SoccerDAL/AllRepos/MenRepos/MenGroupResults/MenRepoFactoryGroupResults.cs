using SoccerDAL.AllRepos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.MenRepos.MenGroupResults
{
    public static class MenRepoFactoryGroupResults
    {
        public static IRepoGroupResults GetRepo() => new GroupResultsRepoMen(new HttpClient());
    }
}
