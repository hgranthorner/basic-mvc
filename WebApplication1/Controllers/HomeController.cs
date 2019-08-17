using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            var player = new Player {Name = "Pipes", PlayerName = "Gil"};
            return View(player);
        }
    }
}