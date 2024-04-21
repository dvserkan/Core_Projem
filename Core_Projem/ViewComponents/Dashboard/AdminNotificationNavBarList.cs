using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.ViewComponents.Dashboard
{
	public class AdminNotificationNavBarList : ViewComponent
	{
		AnnouncementManager c = new AnnouncementManager(new EfAnnouncementDal());
		public IViewComponentResult Invoke()
		{
			var values = c.TGetlist();
			ViewBag.count = c.TGetlist().Count();
			return View(values);
		}
	}
}
