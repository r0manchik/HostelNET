using HostelNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace HostelNET.Controllers
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
            return View();
        }

        [HttpGet]
        public IActionResult Service()
        {
            return View();
        }

        [HttpPost]
        public void Service(string name, string email, string option, string content)
        {
            var NoSQLcon = new Service_NoSQL() { Name = name, Email = email, Type = option, Description = content };
            NoSQLcon.Service_InsertInto();
        }

        [HttpGet]
        public IActionResult Work()
        {
            return View();
        }

        [HttpPost]
        public void Work(string name, string email, string option, string content)
        {
            if (!int.TryParse(option, out int type))
            {
                type = 0;
            }
            var SQLcon = new Work_SQL() { Name = name, Email = email, Type = type, Description = content };
            SQLcon.Work_InsertInto();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult Login()
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
