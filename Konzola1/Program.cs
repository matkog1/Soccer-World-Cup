using Newtonsoft.Json;
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
using SoccerDAL.AllRepos.TeamsRepo;
using SoccerDAL.AllRepos.AllMatchesByCountryRepo;
using SoccerDAL.AllRepos.PlayerRepo;
using SoccerDAL.Comparer;
using SoccerDAL.AllRepos.WomenRepos.WomenAllMatches;
using SoccerDAL.AllRepos.WomenRepos.WomenAllMatchesByCountryRepo;
using SoccerDAL.AllRepos.WomenRepos.WomenTeams;
using SoccerDAL.AllRepos.WomenRepos.WomenTeamsResults;
using SoccerDAL.AllRepos.WomenRepos.WomenGroupResults;

internal class Program
{
    private static async Task Main(string[] args)
    {

        //Print all matches, radi men i women
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

        /* //Print all teams, radi men i women 
        IRepoTeams teamsRepo = WomenRepoFactoryTeams.GetRepo();
        IList<Team> teamsList = await teamsRepo.GetAllTeams();
        
        
        List<Team> sortedList = new List<Team>(teamsList);
        sortedList.Sort(new PropertyComparer<Team>("group_id"));
       
        Utility.Print(sortedList);
        */
        
        /*  //Print all teams results, radi men i women
        IRepoTeamsResults repoTeamsResults = MenRepoFactoryTeamsResults.GetRepo();
        IList<TeamResults> teamResults = await repoTeamsResults.GetTeamsResults();
        Utility.Print(teamResults);
       */ 
        
       /*  //Print all group results, radi men i women
        IRepoGroupResults repoGroupResults = MenRepoFactoryGroupResults.GetRepo();
        IList<Group> groupsResults = await repoGroupResults.GetGroupResults();
        Utility.Print(groupsResults);
        */

        //Print all players from jsonfile but not api
        //ovo treba prepravit da radi sa json u projektu bez hardkodinga putanje
        /*IRepoPlayer playerRepository = MenRepoFactoryPlayer.GetRepo();
        List<Player> players = playerRepository.GetPlayersFromJsonFile();
        Utility.Print(players);
        */
    }
}