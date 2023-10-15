using CafeProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace CafeProject.ViewComponents.Fotter
{
    public class _Fotter : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var result = context.FotterDbSet.OrderByDescending(x => x.ID).Take(1).ToList();
            return View(result);
        }
    }
}
