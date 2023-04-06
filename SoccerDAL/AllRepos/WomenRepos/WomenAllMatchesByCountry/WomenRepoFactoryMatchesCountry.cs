using SoccerDAL.AllRepos.AllMatchesByCountryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.WomenRepos.WomenAllMatchesByCountryRepo
{
    public class WomenRepoFactoryMatchesCountry
    {
        public static IRepoAllMatchesByCountry GetRepo() => new WomenAllMatchesByCountryRepo(new HttpClient());
    }
}
