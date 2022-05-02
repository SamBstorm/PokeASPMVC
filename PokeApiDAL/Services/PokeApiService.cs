using PokeApiDAL.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace PokeApiDAL.Services
{
    public class PokeApiService
    {
        private readonly HttpClient _http;

        public PokeApiService(HttpClient http)
        {
            _http = http;
        }

        public async Task<PokeApiResult> GetByName(string pokeName) {
            return await _http.GetFromJsonAsync<PokeApiResult>($"pokemon/{pokeName}");
        }
    }
}
