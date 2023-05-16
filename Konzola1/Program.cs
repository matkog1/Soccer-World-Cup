
using Newtonsoft.Json.Linq;
using SoccerDAL.AllRepos;
using SoccerDAL.Utility;
using System;
using System.Collections.Immutable;
using System.Reflection;
using SoccerDAL.AllRepos.WomenRepos.WomenAllMatches;
using SoccerDAL.AllRepos.WomenRepos.WomenGroupResults;
using SoccerDAL.AllRepos.WomenRepos.WomenPlayers;
using SoccerDAL.AllRepos.WomenRepos.WomenTeams;
using SoccerDAL.AllRepos.WomenRepos.WomenTeamsResults;
using SoccerDAL.Comparer;
using SoccerDAL.Models;
using System.Collections.Generic;
using System.Net.Http.Headers;
using SoccerDAL.AllRepos.Interfaces;
using SoccerDAL.AllRepos.MenRepos.MenAllMatches;
using SoccerDAL.AllRepos.WomenRepos.WomenAllMatchesByCountry;
using SoccerDAL.AllRepos.MenRepos.MenPlayers;
using SoccerDAL.AllRepos.MenRepos.MenAllMatchesByCountry;
using System.Text.RegularExpressions;

internal class Program
{
    private static async Task Main(string[] args)
    {

        IRepoAllMatches matchesRepo = MenRepoFactoryAllMatches.GetRepo();
        IList<Matches> matches = await matchesRepo.GetAllMatches();
        List<Matches> matches1 = matches.ToList();
        List<Home_Team_Events> team = new List<Home_Team_Events>();
        List<Away_Team_Events> team_away = new List<Away_Team_Events>();
        int count1 = 0;
        int count2 = 0;
        foreach (var item in matches1)
        {
            foreach (var events1 in item.home_team_events)
            {
                team.Add(events1);
            }

            foreach (var items in team)
            {
                await Console.Out.WriteLineAsync(items.ToString());
            }


            /*
             //Print all matches by country, radi men i women
            IRepoAllMatchesByCountry matchesRepoByCountry = MenRepoFactoryMatchesCountry.GetRepo(); //MenRepoFactoryMatchesCountry
            IList<Matches> matchesCountry = await matchesRepoByCountry.MatchesByCountry("ENG");
            List<Matches> matchesList  = matchesCountry.ToList();

            foreach (var item in matchesList)
            {
                await Console.Out.WriteLineAsync(item.attendance.ToString());
                await Console.Out.WriteLineAsync(item.venue.ToString());
                await Console.Out.WriteLineAsync(item.home_team_country.ToString());
                await Console.Out.WriteLineAsync(item.away_team_country.ToString());
            }
            */

            /*
            Utility.Print(matchesCountry);
           */

            /*
             //Print all group results, radi men i women
             IRepoGroupResults repoGroupResults = WomenRepoFactoryGroupResults.GetRepo();
             IList<Group> groupsResults = await repoGroupResults.GetGroupResults();
             Utility.Print(groupsResults);
             */
            /*
            IRepoPlayer playerRepository = MenRepoFactoryPlayer.GetRepo();
            var players = playerRepository.GetPlayersFromJsonFile();
            Utility.Print(players);
            */
            /*Print dicioanry of key= country, value = players
            IRepoPlayer repo = MenRepoFactoryPlayer.GetRepo();
            Dictionary<string, List<Player>> pairs = repo.GetPlayersByCountryFromJsonFile();

            Utility.PrintDictionaryPlayers(pairs);
            */


            /* //Print all teams, radi men i women 
            IRepoTeams teamsRepo = WomenRepoFactoryTeams.GetRepo();
            IList<Team> teamsList = await teamsRepo.GetAllTeams();
            Utility.Print(teamsList);
            */

            /*
            List<Team> sortedList = new List<Team>(teamsList);
            sortedList.Sort(new PropertyComparer<Team>("group_id"));
            Utility.Print(sortedList);
            */

            /*  //Print all teams results, radi men i women
            IRepoTeamsResults repoTeamsResults = WomenRepoFactoryTeamsResults.GetRepo();
            IList<TeamResults> teamResults = await repoTeamsResults.GetTeamsResults();
            Utility.Print(teamResults);
            */
        }


    }
}

