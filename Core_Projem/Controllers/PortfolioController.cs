using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.Controllers
{
    
    public class PortfolioController : Controller
    {
        PortfolioManager mana = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            var values = mana.TGetlist();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
            mana.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeletePortfolio(int id)
        {
            var values = mana.TGetByID(id);
            mana.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            var values = mana.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditPortfolio(Portfolio p)
        {
            mana.TUpdate(p);
            return RedirectToAction("Index");
        }

    }
}
