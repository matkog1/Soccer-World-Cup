using SoccerDAL.AllRepos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.WomenRepos.WomenAllMatchesByCountry
{
    public class WomenRepoFactoryMatchesCountry
    {
        public static IRepoAllMatchesByCountry GetRepo() => new WomenAllMatchesByCountryRepo(new HttpClient());
    }
}
