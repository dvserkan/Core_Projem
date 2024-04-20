using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.Areas.Writer.ViewComponents
{
    public class Notification : ViewComponent
    {
        AnnouncementManager c = new AnnouncementManager(new EfAnnouncementDal());
        public IViewComponentResult Invoke()
        {
            var values = c.TGetlist();
            return View(values);
        }
	
	}
}
