using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.ViewComponents.Dashboard
{
	public class MessageList : ViewComponent
	{
		UserMessageManager c = new UserMessageManager(new EfUserMessageDal());
		public IViewComponentResult Invoke()
		{
			var values = c.GetUserMessageWithUserService();
			return View(values);
		}

	}
}
