using Microsoft.AspNetCore.Mvc;
namespace JGPaintballShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
