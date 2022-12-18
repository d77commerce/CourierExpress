using Microsoft.AspNetCore.Mvc;

namespace CourierExpress.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
