using SoccerDAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.GroupResultsRepo
{
    public static class RepoFactoryGroupResults
    {
        public static IRepoGroupResults GetRepo() => new GroupResultsRepo();
    }
}
