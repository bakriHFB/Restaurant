using app.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace app.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index action started");
            // Your controller logic here
            _logger.LogInformation("Index action completed");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Index action started");
            // Your controller logic here
            _logger.LogInformation("Index action completed");
            return View();
        }
        public IActionResult Show()
        {
            _logger.LogInformation("Index action started");
            // Your controller logic here
            _logger.LogInformation("Index action completed");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}