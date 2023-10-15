using CafeProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace CafeProject.ViewComponents.Banner
{
    public class _Banner : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var result = context.BannerDbSet.ToList();
            return View(result); 
        }
    }
}
