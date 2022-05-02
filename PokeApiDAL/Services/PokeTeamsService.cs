using PokeApiDAL.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace PokeApiDAL.Services
{
    public class PokeTeamsService
    {
        private readonly HttpClient _http;

        public PokeTeamsService(HttpClient http)
        {
            _http = http;
        }

        public async Task<IEnumerable<PokeTeamsResult>> GetAll() {
            return await _http.GetFromJsonAsync<IEnumerable<PokeTeamsResult>>("teams");
        }
        public async Task<PokeTeamsResult> GetOne(int id)
        {
            return await _http.GetFromJsonAsync<PokeTeamsResult>($"teams/{id}");
        }

        public async Task<PokeTeamsResult> Create(PokeTeamsResult newTeam) {
            HttpResponseMessage response = await _http.PostAsJsonAsync<PokeTeamsResult>("teams", newTeam);
            return await response.Content.ReadFromJsonAsync<PokeTeamsResult>();
        }
    }
}
