using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AboutController : Controller
    {
        AboutManager c = new AboutManager(new EfAboutDal());
        public IActionResult Index()
        {
            var values = c.TGetlist();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAbout(About p )
        {
            AboutValidator  validations = new AboutValidator();
            ValidationResult result = validations.Validate(p);

            if (result.IsValid)
            {
                c.TAdd(p);
                return RedirectToAction("Index");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
        }

        public IActionResult DeleteAbout(int id)
        {
            var values = c.TGetByID(id);
            c.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            var values = c.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditAbout(About p)
        {
            c.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
