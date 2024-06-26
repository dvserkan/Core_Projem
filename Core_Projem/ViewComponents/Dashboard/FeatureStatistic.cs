﻿using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.ViewComponents.Dashboard
{
	public class FeatureStatistic : ViewComponent
	{
		Context c = new Context();
		public IViewComponentResult Invoke()
		{
			ViewBag.v1 = c.Skills.Count();
			ViewBag.v2 = c.Messages.Where(x => x.Status == false).Count();
			ViewBag.v3 = c.Messages.Where(x => x.Status == true).Count();
			ViewBag.v4 = c.Portfolios.Count();

			return View();
		}

	}
}
