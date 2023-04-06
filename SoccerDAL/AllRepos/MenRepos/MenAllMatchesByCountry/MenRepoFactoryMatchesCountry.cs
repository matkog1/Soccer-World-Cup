using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.AllMatchesByCountryRepo
{
    public static class MenRepoFactoryMatchesCountry
    {
        public static IRepoAllMatchesByCountry GetRepo() => new MenAllMatchesByCountryRepo(new HttpClient());
    }
}
