﻿using Newtonsoft.Json;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.AllMatchesByCountryRepo
{
    public interface IRepoAllMatchesByCountry
    {
        Task<List<Matches>> MatchesByCountry(string fifa_code);

    }
}
