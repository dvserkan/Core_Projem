using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.Controllers
{
    public class AdminController : Controller
    {
        [Authorize(Roles = "Admin")]
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }

        public PartialViewResult NewSideBar()
        {
            return PartialView();   
        }
        public PartialViewResult NewScript()
        {
            return PartialView();
        }
    }
}
