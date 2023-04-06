using SoccerDAL.AllRepos.GroupResultsRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.WomenRepos.WomenGroupResults
{
    public static class WomenRepoFactoryGroupResults
    {
        public static IRepoGroupResults GetRepo() => new GroupResultsRepoWomen(new HttpClient());
    }
}
