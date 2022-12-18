 using CourierExpress.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
 using CourierExpress.Core.Contracts;
 using CourierExpress.Infrastructure.Data;
 using CourierExpress.Infrastructure.Models;

 namespace CourierExpress.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IOrderServices orderServices;
        private readonly ILogger<HomeController> logger;

        public HomeController(ILogger<HomeController> _logger)
        {
           // orderServices = _orderServices;
            logger = _logger;
        }

        public async Task<IActionResult> Index()
        {
    
            return  View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}