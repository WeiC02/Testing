using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Testing.Models;
using Microsoft.Extensions.Configuration;

namespace Testing.Controllers
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
           
            // Create a sample User object
            var user = new User
            {
                Id = 1,
                Name = "Xin Jun",
                Email = "xin@example.com"
            };
         
            return View(user); 
          
        }

        public IActionResult Privacy()
        {

            return View();
        }

        public IActionResult Profile()
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
