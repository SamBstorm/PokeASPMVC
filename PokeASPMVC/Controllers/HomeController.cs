using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PokeApiDAL.Models;
using PokeASPMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PokeASPMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PokeApiDAL.Services.PokeApiService _apiService;
        private readonly PokeApiDAL.Services.PokeTeamsService _localapiService;

        public HomeController(
            ILogger<HomeController> logger, 
            PokeApiDAL.Services.PokeApiService apiService, 
            PokeApiDAL.Services.PokeTeamsService localapiService
            )
        {
            _logger = logger;
            _apiService = apiService;
            _localapiService = localapiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> pokemon(string id) {
            PokeApiResult model = await _apiService.GetByName(id);
            return View(model);
        }

        public IActionResult SetTeam() {
            PokemonTeamsForm model = new PokemonTeamsForm();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SetTeam(PokemonTeamsForm model)
        {
            if(!ModelState.IsValid) return View(model);
            PokeTeamsResult result = new PokeTeamsResult()
            {
                name = model.name,
                pokemon_1_id = model.pokemon_1_id,
                pokemon_2_id = model.pokemon_2_id,
                pokemon_3_id = model.pokemon_3_id,
                pokemon_4_id = model.pokemon_4_id,
                pokemon_5_id = model.pokemon_5_id,
                pokemon_6_id = model.pokemon_6_id
            };
            result = await _localapiService.Create(result);
            return RedirectToAction("TeamsDetail", new { id = result.id });
        }
    }
}
