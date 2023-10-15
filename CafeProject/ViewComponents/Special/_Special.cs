using Microsoft.AspNetCore.Mvc;

namespace CafeProject.ViewComponents.Special
{
    public class _Special : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
