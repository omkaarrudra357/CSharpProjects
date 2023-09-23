﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TagHelperDemo.Models;
using Microsoft.AspNetCore.Http.Features;
using System.Text;

namespace TagHelperDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration=configuration;
        }

        public IActionResult Menu()
        {
            String conString = _configuration.GetConnectionString("DefaultConnection");
            _logger.Log(LogLevel.Information, conString);
            return View();
        }
        public ActionResult Echo(String name, String City)
        {
            String s1 = "user " + name + " from City=" + City;
            ViewData.Add("Data1", s1);
            return View();
        }
        public ActionResult SayHello(String name)
        {
            String s1 = ("hello "+ name);
            ViewData.Add("Data1", s1);
            return View("Echo");
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int x, IFormCollection collection)
        {
            StringBuilder data = new StringBuilder(500);
            data.Append("x: ");
            data.Append(x);
            data.Append(" ");
            data.Append("name: ");
            data.Append(collection["name"]);
            data.Append(" ");
            data.Append("password: ");
            data.Append(collection["password"]);
            //foreach (var item in collection)
            //{
            //    data.Append(item.Key);
            //    data.Append(": ");
            //    data.Append(item.Value);
            //    data.Append(" ");
            //}
            ViewData["x"] = data.ToString();
            return View("IndexPost");
        }
        public ActionResult DoTask(int? id)
        {
            if (id.HasValue)
            {
                ViewData["id"] = id.Value;
            }
            else
            {
                ViewData["id"] = 0;
            }
            return View();
        }
        public ActionResult Test()
        {

            return RedirectToAction("Index");
        }
        public IActionResult GetBook()
        {
            Book b1 = new Book()
            {
                AuthorName = "H Lee"
            };
            ViewData["book"] = b1;
            return View();
        }

        [ResponseCache(Duration =1)]
        public IActionResult GetTime()
        {
            String todate = DateTime.Now.ToLongTimeString();
            ViewData["data"] = todate;
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