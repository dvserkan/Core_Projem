using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.Controllers
{
   
    public class DashboardController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
