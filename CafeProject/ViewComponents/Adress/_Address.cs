using CafeProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace CafeProject.ViewComponents.Adress
{
    public class _Address : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var result = context.AddressDbSet.OrderByDescending(x=>x.ID).Take(1).ToList();
            return View(result);  
        }
    }
}
