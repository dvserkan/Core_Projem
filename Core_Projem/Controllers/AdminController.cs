using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }



    }
}
