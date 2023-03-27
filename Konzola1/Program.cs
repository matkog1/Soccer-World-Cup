// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SoccerDAL.Models;
using SoccerDAL.Repo;
using SoccerDAL.Utility;
using System;
using System.Collections.Immutable;
using System.Reflection;


internal class Program
{
    private static async Task Main(string[] args)
    {
        /*
         //GetTeamResults sa Api
         ApiRequests api = new ApiRequests();

         IList<TeamResults>? teamResults = await api.GetAllMatchesAsync();

         foreach (var item in teamResults)
         {
             await Console.Out.WriteAsync(item.ToString());
         }
        */

        /*
         //GetAllTeams sa apija
         ApiRequests apiGetTeams = new ApiRequests();
         IList<Team> teams = await apiGetTeams.GetAllTeams();

         foreach (Team team in teams)
         {
             await Console.Out.WriteLineAsync(team.ToString());
         }
        */

        /*
         ApiRequests apiGetGroupResults = new ApiRequests();
         IList<Group> GetGroupResults = await apiGetGroupResults.GetGroupResults();

         foreach (var item in GetGroupResults)
         {
             await Console.Out.WriteLineAsync(item.ToString());
         }
       */
        /*
         ApiRequests apiGetMatchesByCountry = new ApiRequests();
         IList<Matches> GetGroupResults = await apiGetMatchesByCountry.MatchesByCountry("CRO");

         foreach (var item in GetGroupResults)
         {
             await Console.Out.WriteLineAsync(item.ToString());
         }
         */

 
            ApiRequests apiGetAllMatches = new ApiRequests();
            IList<Matches> getMatches = await apiGetAllMatches.GetAllMatches();

            foreach (var item in getMatches)
            {
                await Console.Out.WriteLineAsync(item.ToString());
            }

    
    }

}