using CafeProject.Data;
using CafeProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CafeProject.Controllers
{
    public class HomeController : Controller
    {
        Context context= new Context();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Reservation(ReservationModel p)
        {
            if (ModelState.IsValid)
            {
                Reservations newReservation = new Reservations
                {
                    Name = p.Name,
                    Date = p.Date,
                    Email = p.Email,
                    Guest = p.Guest,
                    Message = p.Message,
                    Phone = p.Phone,
                    Status = true,
                    Time = p.Time
                };
                context.ReservationbSet.Add(newReservation);
                context.SaveChanges();
                 ViewBag.SuccessMessage = "Rezervasyon başarıyla tamamlandı";
                return RedirectToAction("Index");
            }
            return View(p);
        }
    }
}