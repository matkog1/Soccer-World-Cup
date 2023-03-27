// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SoccerDAL.GroupResultsRepo;
using SoccerDAL.Models;
using SoccerDAL.Repo;
using SoccerDAL.TeamsRepo;
using SoccerDAL.TeamsResultsRepo;
using SoccerDAL.Utility;
using System;
using System.Collections.Immutable;
using System.Reflection;


internal class Program
{
    private static async Task Main(string[] args)
    {

        /*
        IRepoAllMatches matchesRepo = RepoFactoryMatches.GetRepo();
        IList<Matches> matches = await matchesRepo.GetAllMatches();
        Utility.Print(matches);
        */
        /*
        IRepoAllMatchesByCountry matchesRepo = RepoFactoryMatchesCountry.GetRepo();
        IList<Matches> matchesCountry = await matchesRepo.MatchesByCountry("GER");
        Utility.Print(matchesCountry);
        */
        /*
        IRepoTeams teamsRepo = RepoFactoryTeams.GetTeams();
        IList<Team> teamsList = await teamsRepo.GetAllTeams();
        Utility.Print(teamsList);
        */
        /*
        IRepoTeamsResults repoTeamsResults = RepoFactoryTeamsResults.GetRepo();
        IList<TeamResults> teamResults = await repoTeamsResults.GetTeamsResults();
        Utility.Print(teamResults);
        */

        IRepoGroupResults repoGroupResults = RepoFactoryGroupResults.GetRepo();
        IList<Group> groupsResults = await repoGroupResults.GetGroupResults();
        Utility.Print(groupsResults);
    }

}