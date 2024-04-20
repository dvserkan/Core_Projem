using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.Controllers
{
    public class TestController : Controller
    {
        ExperienceManager man = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            var values = man.TGetlist();
            return View(values);
        }
    }
}
