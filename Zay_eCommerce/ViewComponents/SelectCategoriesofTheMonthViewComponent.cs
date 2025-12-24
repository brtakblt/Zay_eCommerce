using Microsoft.AspNetCore.Mvc;

namespace Zay_eCommerce.ViewComponents
{
    public class SelectCategoriesofTheMonthViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
