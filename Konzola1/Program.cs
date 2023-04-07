using SoccerDAL.AllRepos.PlayerRepo;
using Newtonsoft.Json.Linq;
using SoccerDAL.AllRepos;
using SoccerDAL.Utility;
using System;
using System.Collections.Immutable;
using System.Reflection;
using SoccerDAL.Models;
using SoccerDAL.AllRepos.AllMatchesRepo;
using SoccerDAL.AllRepos.GroupResultsRepo;
using SoccerDAL.AllRepos.TeamsResultsRepo;
using SoccerDAL.AllRepos.WomenRepos.WomenAllMatches;
using SoccerDAL.AllRepos.AllMatchesByCountryRepo;
using SoccerDAL.AllRepos.WomenRepos.WomenAllMatchesByCountryRepo;
using SoccerDAL.AllRepos.WomenRepos.WomenGroupResults;
using SoccerDAL.AllRepos.WomenRepos.WomenPlayers;
using SoccerDAL.AllRepos.TeamsRepo;
using SoccerDAL.AllRepos.WomenRepos.WomenTeams;

internal class Program
{
    private static async Task Main(string[] args)
    {
        /*
        IRepoAllMatches matchesRepo = WomenRepoFactoryAllMatches.GetRepo(); //MenRepoFactoryAllMatches.GetRepo();
        IList<Matches> matches = await matchesRepo.GetAllMatches();
        Utility.Print(matches);
        */

        /*  //Print all matches by country, radi men i women
         IRepoAllMatchesByCountry matchesRepoByCountry = WomenRepoFactoryMatchesCountry.GetRepo(); //MenRepoFactoryMatchesCountry
         IList<Matches> matchesCountry = await matchesRepoByCountry.MatchesByCountry("ENG");
         Utility.Print(matchesCountry);
        */

        /* //Print all group results, radi men i women
         IRepoGroupResults repoGroupResults = WomenRepoFactoryGroupResults.GetRepo();
         IList<Group> groupsResults = await repoGroupResults.GetGroupResults();
         Utility.Print(groupsResults);
         */
        /*
        IRepoPlayer playerRepository = WomenRepoFactoryPlayer.GetRepo();
        List<Player> players = playerRepository.GetPlayersFromJsonFile();
        Utility.Print(players);
        */

         //Print all teams, radi men i women 
        IRepoTeams teamsRepo = WomenRepoFactoryTeams.GetRepo();
        IList<Team> teamsList = await teamsRepo.GetAllTeams();
        Utility.Print(teamsList);
        

        /*
        List<Team> sortedList = new List<Team>(teamsList);
        sortedList.Sort(new PropertyComparer<Team>("group_id"));
        Utility.Print(sortedList);
        */

        /*  //Print all teams results, radi men i women
        IRepoTeamsResults repoTeamsResults = MenRepoFactoryTeamsResults.GetRepo();
        IList<TeamResults> teamResults = await repoTeamsResults.GetTeamsResults();
        Utility.Print(teamResults);
       */


    
    }
}