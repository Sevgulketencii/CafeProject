using CafeProject.Data;
using CafeProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CafeProject.ViewComponents.Reservation
{
    public class _Reservation : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
