using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.ViewComponents.Dashboard
{
	public class MessageList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
