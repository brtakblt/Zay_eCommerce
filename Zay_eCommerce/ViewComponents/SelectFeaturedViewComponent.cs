using Microsoft.AspNetCore.Mvc;

namespace Zay_eCommerce.ViewComponents
{
    public class SelectFeaturedViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
