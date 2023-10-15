using CafeProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace CafeProject.ViewComponents.Special
{
    public class _Special : ViewComponent

    {
        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            var result = context.MenuDbSet.Where(x => x.SpecialFood == true).OrderBy(x=>x.ID).Take(4).ToList();
            return View(result);
        }
    }
}
