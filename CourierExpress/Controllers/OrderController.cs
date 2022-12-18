using CourierExpress.Core.Models.Order;
using CourierExpress.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace CourierExpress.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderServices orderServices; 
        private readonly Order order;
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Track()
        {
          
            return View();
        }
        public async Task<IActionResult> ShoWTracking(int trackId)
        {
            await orderServices.TrackById(trackId);
            return View();
        }
    }
}
