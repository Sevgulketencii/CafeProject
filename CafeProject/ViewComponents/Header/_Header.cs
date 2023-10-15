using Microsoft.AspNetCore.Mvc;

namespace CafeProject.ViewComponents.Header
{
    public class _Header : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
