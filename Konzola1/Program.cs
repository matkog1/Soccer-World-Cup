using SoccerDAL.AllRepos.PlayerRepo;
using SoccerDAL.AllRepos.TeamsResultsRepo;
using SoccerDAL.Models;
using SoccerDAL.Utility;

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
        IRepoTeams teamsRepo = MenRepoFactoryTeams.GetRepo();
        IList<Team> teamsList = await teamsRepo.GetAllTeams();
        Utility.Print(teamsList);
        */
        /*
        List<Team> sortedList = new List<Team>(teamsList);
        sortedList.Sort(new PropertyComparer<Team>("group_id"));
        Utility.Print(sortedList);
        */

        /*//Print all teams results, radi men i women
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
        IRepoPlayer playerRepository = MenRepoFactoryPlayer.GetRepo();
        List<Player> players = playerRepository.GetPlayersFromJsonFile();
        Utility.Print(players);
        
    }
}