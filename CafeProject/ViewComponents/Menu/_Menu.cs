using CafeProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace CafeProject.ViewComponents.Menu
{
    public class _Menu : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var result = context.MenuDbSet.ToList();
            return View(result);
        }
    }
}
