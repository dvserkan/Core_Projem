using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager man = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            var values = man.TGetlist();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            man.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var values = man.TGetByID(id);
            man.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            var values = man.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditExperience(Experience p)
        {
            man.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
