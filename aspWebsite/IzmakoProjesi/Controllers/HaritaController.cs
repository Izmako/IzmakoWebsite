using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IzmakoProjesi.Models;

namespace IzmakoProjesi.Controllers
{
    public class HaritaController : Controller
    {
        private readonly ILogger<HaritaController> _logger;

        public HaritaController(ILogger<HaritaController> logger)
        {
            _logger = logger;
        }

        public IActionResult HaritaPage()
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
    }
}
