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
using SoccerDAL.Comparer;

internal class Program
{
    private static async Task Main(string[] args)
    {

        /*//Print all matches
        IRepoAllMatches matchesRepo = RepoFactoryMatches.GetRepo();
        List<Matches> matches = await matchesRepo.GetAllMatches();
        Utility.Print(matches);


         //Print all matches by country
        IRepoAllMatchesByCountry matchesRepoByCountry = RepoFactoryMatchesCountry.GetRepo();
        List<Matches> matchesCountry = await matchesRepoByCountry.MatchesByCountry("ENG");
        Utility.Print(matchesCountry);
        */

         //Print all teams
        IRepoTeams teamsRepo = RepoFactoryTeams.GetRepo();
        List<Team> teamsList = await teamsRepo.GetAllTeams();
        teamsList.Sort(new PropertyComparer<Team>("country"));
        Utility.Print(teamsList);
        
        /*
          //Print all teams results
        IRepoTeamsResults repoTeamsResults = RepoFactoryTeamsResults.GetRepo();
        List<TeamResults> teamResults = await repoTeamsResults.GetTeamsResults();
        Utility.Print(teamResults);
        

        //Print all group results
        IRepoGroupResults repoGroupResults = RepoFactoryGroupResults.GetRepo();
        List<Group> groupsResults = await repoGroupResults.GetGroupResults();
        Utility.Print(groupsResults);
        */

    }
}