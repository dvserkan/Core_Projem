using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.Controllers
{
	[AllowAnonymous]
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult HeaderPartial()
		{
			return PartialView();
		}
		public PartialViewResult NavbarPartial()
		{
			return PartialView();
		}

		[HttpGet]
		public IActionResult SendMessage()
		{
			return View();
		}


        [HttpPost]
        public IActionResult SendMessage(Message p)
        {
            MessageManager message = new MessageManager(new EfMessageDal());

            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status = true;
            message.TAdd(p);

            return RedirectToAction("Index","Default");
        }

    }
}
