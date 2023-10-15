using CafeProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace CafeProject.ViewComponents.SpecialRight
{
    public class _SpecialRight : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var result = context.MenuDbSet.Where(x => x.SpecialFood == true).OrderBy(x => x.ID).Skip(4).Take(4).ToList();
            return View(result);
        }
    }
}
