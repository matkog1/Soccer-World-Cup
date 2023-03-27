
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

internal class Program
{
    private static async Task Main(string[] args)
    {

        /* //Print all matches
        IRepoAllMatches matchesRepo = RepoFactoryMatches.GetRepo();
        IList<Matches> matches = await matchesRepo.GetAllMatches();
        Utility.Print(matches);
        */
        
        /* //Print all matches by country
        IRepoAllMatchesByCountry matchesRepoByCountry = RepoFactoryMatchesCountry.GetRepo();
        IList<Matches> matchesCountry = await matchesRepoByCountry.MatchesByCountry("CRO");
        Utility.Print(matchesCountry);
        */
        
        /* //Print all teams
        IRepoTeams teamsRepo = RepoFactoryTeams.GetRepo();
        IList<Team> teamsList = await teamsRepo.GetAllTeams();
        Utility.Print(teamsList);
        */
        
         /* //Print all teams results
        IRepoTeamsResults repoTeamsResults = RepoFactoryTeamsResults.GetRepo();
        IList<TeamResults> teamResults = await repoTeamsResults.GetTeamsResults();
        Utility.Print(teamResults);
        */
        
        /* /Print all group results
        IRepoGroupResults repoGroupResults = RepoFactoryGroupResults.GetRepo();
        IList<Group> groupsResults = await repoGroupResults.GetGroupResults();
        Utility.Print(groupsResults);
        */

    }
}