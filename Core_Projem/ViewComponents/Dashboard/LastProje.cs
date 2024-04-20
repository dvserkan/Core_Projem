using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Core_Projem.ViewComponents.Dashboard
{
	public class LastProje : ViewComponent
	{
		Context  c = new Context();
		public IViewComponentResult Invoke()
		{
			var values = c.Portfolios.OrderByDescending(x=> x.PortfolioID).Take(1).ToList();	
			return View(values);
		}
	}
}
