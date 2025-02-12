using Microsoft.AspNetCore.Mvc;
using Testing.Models;
using Microsoft.Extensions.Configuration;

namespace Testing.Controllers
{
    public class UserController : Controller
    {
       
        public IActionResult Index()
        {
    
            // Create a sample User object
            var user = new User
            {
                Id = 1,
                Name = "Xin Jun",
                Email = "xin@example.com"
            };
           
            return View(user); // ✅ Pass model to the view
            // Pass values to View
           
           
        }
    }
}
