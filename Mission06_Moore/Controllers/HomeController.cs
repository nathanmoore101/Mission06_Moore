using Microsoft.AspNetCore.Mvc;
using Mission06_Moore.Models;
using System.Diagnostics;

namespace Mission06_Moore.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext _context;
        public HomeController(MovieFormContext temp) 
        {
            _context = temp;
        
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Info()
        {
            return View();
        }
        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Application response)
        {
            _context.Applications.Add(response);
            _context.SaveChanges();
            return View("Confirmation", response);
        }
    }
}
