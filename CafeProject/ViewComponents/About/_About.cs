using CafeProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace CafeProject.ViewComponents.About
{
    public class _About : ViewComponent
    {
        Context context= new Context();
        public IViewComponentResult Invoke()
        {
           var result = context.AboutDbSet.OrderByDescending(x=>x.ID).Take(1).ToList();
           return View(result);
        }
    }
}
