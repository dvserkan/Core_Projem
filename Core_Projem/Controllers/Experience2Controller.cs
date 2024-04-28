using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core_Projem.Controllers
{
	public class Experience2Controller : Controller
	{
		ExperienceManager manager = new ExperienceManager(new EfExperienceDal());
		public IActionResult Index()
		{

			return View();
		}
		public IActionResult ListExperience()
		{
			var values = JsonConvert.SerializeObject(manager.TGetlist());
			return Json(values);
		}

		[HttpPost]
		public IActionResult AddExperience(Experience p)
		{
			manager.TAdd(p);
			var values = JsonConvert.SerializeObject(p);
			return Json(values);
		}




	}
}
