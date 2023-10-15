using CafeProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace CafeProject.ViewComponents.Chefs
{
    public class _Chefs : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var result = context.ChefsDbSet.ToList();
            return View(result);
        }
    }
}
