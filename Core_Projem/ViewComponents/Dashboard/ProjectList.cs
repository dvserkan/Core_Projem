using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.ViewComponents.Dashboard
{
	public class ProjectList : ViewComponent
	{
		Context c = new Context();
		public IViewComponentResult Invoke()
		{
			var values = c.Portfolios.ToList();
			return View(values);
		}

	}
}
