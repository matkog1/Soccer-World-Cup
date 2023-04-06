﻿using Newtonsoft.Json;
using SoccerDAL.AllRepos.TeamsResultsRepo;
using SoccerDAL.Errors;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.AllRepos.WomenRepos.WomenTeamsResults
{
    internal class WomenTeamsResultsRepo : IRepoTeamsResults
    {
        private readonly string _apiGetTeamsResults = "https://worldcup-vua.nullbit.hr/women/teams/results";
        private readonly HttpClient _client;
        private IList<TeamResults>? _teamResults = new List<TeamResults>();

        public WomenTeamsResultsRepo(HttpClient client)
        {
            _client = client;
        }

        public async Task<IList<TeamResults>> GetTeamsResults()
        {
            try
            {
                using var response = await _client.GetAsync(_apiGetTeamsResults);
                await ApiErrorHandler.HandleErrorAsync(response);
                var json = await response.Content.ReadAsStringAsync();
                _teamResults = JsonConvert.DeserializeObject<IList<TeamResults>>(json);
                return _teamResults ?? new List<TeamResults>();

            }
            catch (Exception ex)
            {

                await Console.Out.WriteLineAsync($"Error occured: {ex.Message}");
                throw;
            }

            finally { _client.Dispose(); }
        }
    }
}
