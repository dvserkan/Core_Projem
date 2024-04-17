using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.Controllers
{
    public class SkillController : Controller
    {
        SkillManager mana = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values = mana.TGetlist();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill p)
        {
            mana.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var values = mana.TGetByID(id);
            mana.TDelete(values);
			return RedirectToAction("Index");
		}

        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            var values = mana.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditSkill(Skill p)
        {
            mana.TUpdate(p);
			return RedirectToAction("Index");
		}
    }
}
