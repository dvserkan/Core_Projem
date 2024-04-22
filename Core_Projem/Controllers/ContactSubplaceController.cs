using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ContactSubplaceController : Controller
	{
		ContactManager contactManager = new ContactManager(new EfContactDal());

		[HttpGet]
		public IActionResult Index()
		{
			var values = contactManager.TGetByID(1);
			return View(values);
		}
		[HttpPost]
		public IActionResult Index(Contact contact)
		{
			contactManager.TUpdate(contact);
			return RedirectToAction("Index", "Default");
		}
	}
}
