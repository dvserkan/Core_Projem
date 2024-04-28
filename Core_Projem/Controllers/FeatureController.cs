using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.Controllers
{
 
    public class FeatureController : Controller
    {
        FeatureManager mana = new FeatureManager(new EfFeatureDal());
        public IActionResult Index()
        {
            var  values = mana.TGetlist();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddFeature()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFeature(Feature p)
        {
            mana.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteFeature(int id)
        {
            var values = mana.TGetByID(id);
            mana.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditFeature(int id)
        {
            var values = mana.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditFeature(Feature p)
        {
            mana.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
