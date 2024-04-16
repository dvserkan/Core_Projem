using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Core_Projem.ViewComponents.Service
{
	public class ServiceList : ViewComponent
	{
	
		ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
		public IViewComponentResult Invoke()
		{
			var values = serviceManager.TGetlist();
			return View(values);
		}
	}
}
