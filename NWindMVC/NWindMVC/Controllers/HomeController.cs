using Microsoft.AspNetCore.Mvc;
using NWindMVC.Models;
using System.Diagnostics;

namespace NWindMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly IConfiguration _configuration; 

        public HomeController(ILogger<HomeController> logger /*IConfiguration configuration*/)
        {
            //_configuration = configuration;
            _logger = logger;
        }

        public IActionResult Index()
        {
            //String conString = _configuration.GetConnectionString("NWindConnection");
            //_logger.Log(LogLevel.Information, conString);
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