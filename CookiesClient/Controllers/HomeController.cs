using CookiesClient.Models;
using CookiesClient.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CookiesClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBroRepository _IBroRepository;

        public HomeController(ILogger<HomeController> logger, IBroRepository IBroRepository)
        {
            _logger = logger;
            _IBroRepository = IBroRepository;
        }

        public async Task<IActionResult> Index()
        {
            //logging info
            _logger.LogInformation("Entered Index method");
            var data = await _IBroRepository.Getcookies();
            //logging info
            _logger.LogInformation($"Returning data {JsonSerializer.Serialize(data)}");
            return View(data);
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
    }
}
