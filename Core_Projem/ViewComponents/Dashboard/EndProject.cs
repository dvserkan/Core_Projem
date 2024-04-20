using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.ViewComponents.Dashboard
{
	public class EndProject : ViewComponent
	{
		Context c = new Context();
		public IViewComponentResult Invoke()
		{
			var varlues = c.Portfolios.OrderByDescending(x=> x.PortfolioID).Take(5).ToList();
			return View(varlues);
		}
	}
}
