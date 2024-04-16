using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.ViewComponents.Contact
{
	public class SendMessage : ViewComponent
	{
		MessageManager MessageManager = new MessageManager(new EfMessageDal());

		[HttpGet]
		public IViewComponentResult Invoke()
		{
			return View();
		}
     


    }
}
