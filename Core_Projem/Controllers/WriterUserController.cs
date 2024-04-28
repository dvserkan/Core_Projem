using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core_Projem.Controllers
{
	public class WriterUserController : Controller
	{
		WriterUserManager _userManager = new WriterUserManager(new EfWriterUserDal());
		public IActionResult Index()
		{
			
			return View();
		}
		public IActionResult ListUser()
		{
			var values = JsonConvert.SerializeObject(_userManager.TGetlist());
			return Json(values);
		}

		[HttpPost]
		public IActionResult AddUser(WriterUser p)
		{
			_userManager.TAdd(p);
			var values = JsonConvert.SerializeObject(p);
			return Json(values);	
		}
	}
}
