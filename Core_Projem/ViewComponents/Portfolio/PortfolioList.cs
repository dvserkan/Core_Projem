using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.ViewComponents.Portfolio
{
	public class PortfolioList : ViewComponent
	{
		PortfolioManager _manager = new PortfolioManager(new EfPortfolioDal());

		public IViewComponentResult Invoke()
		{
			var values = _manager.TGetlist();
			return View(values);
		}

	}
}
