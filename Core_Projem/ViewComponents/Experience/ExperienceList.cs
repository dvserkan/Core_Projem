using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.ViewComponents.Experience
{
	public class ExperienceList : ViewComponent
	{
		ExperienceManager experiencemanager = new ExperienceManager(new EfExperienceDal());
		public IViewComponentResult Invoke()
		{
			var values = experiencemanager.TGetlist().OrderByDescending(x => x.Date).ToList();
			return View(values);
		}


	}
}
