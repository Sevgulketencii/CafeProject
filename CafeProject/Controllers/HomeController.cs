using CafeProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CafeProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}