using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.Controllers
{
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
		public PartialViewResult SendMessage()
		{
			return PartialView();
		}


        [HttpPost]
        public PartialViewResult SendMessage(Message p)
        {
            MessageManager message = new MessageManager(new EfMessageDal());

            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status = true;
            message.TAdd(p);

            return PartialView();
        }

    }
}
