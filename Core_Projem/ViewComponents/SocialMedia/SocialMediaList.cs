using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.ViewComponents.SocialMedia
{
	public class SocialMediaList : ViewComponent
	{
		SocialMediaManager c = new SocialMediaManager(new EfSocialMediaDal());
		public IViewComponentResult Invoke()
		{
			var values = c.TGetlist();
			return View(values);
		}
	}
}
