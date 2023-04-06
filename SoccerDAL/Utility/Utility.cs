using Microsoft.CSharp.RuntimeBinder;
using Microsoft.VisualBasic;
using SoccerDAL.AllRepos.AllMatchesRepo;
using SoccerDAL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.Utility
{
    public static class Utility
    {
        public static void Print<T>(IList<T> lista) => lista.ToList().ForEach(item => Console.WriteLine(item));

        public static async Task<IList<Matches>> GetAllMatchesMen()
        {
            IRepoAllMatches matchesRepo = MenRepoFactoryAllMatches.GetRepo();
            IList<Matches> matches = await matchesRepo.GetAllMatches();
            return matches;
        }

    }


}
