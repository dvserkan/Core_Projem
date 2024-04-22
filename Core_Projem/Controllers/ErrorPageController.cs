using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
