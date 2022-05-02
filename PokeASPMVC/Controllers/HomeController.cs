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

        public HomeController(ILogger<HomeController> logger, PokeApiDAL.Services.PokeApiService apiService)
        {
            _logger = logger;
            _apiService = apiService;
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
    }
}
