using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.ViewComponents.Testimonial
{
	public class TestimonialList : ViewComponent
	{
		TestimonialManager manager = new TestimonialManager(new EftestimonialDal());

		public IViewComponentResult Invoke()
		{
			var values = manager.TGetlist();
			return View(values);
		}

	}
}
