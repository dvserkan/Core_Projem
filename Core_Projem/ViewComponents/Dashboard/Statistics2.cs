using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.ViewComponents.Dashboard
{
    public class Statistics2 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Experiences.Count();
            ViewBag.v2 = c.Services.Count();
            ViewBag.v3 = c.Messages.Count();
            return View();
        }
    }
}
