using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.ViewComponents.Dashboard
{
	public class ToDoList : ViewComponent
	{
		ToDoListManager ca = new ToDoListManager(new EfTodoListDal());
		Context c = new Context();
		public IViewComponentResult Invoke()
		{
	
			var values = c.ToDoLists.OrderByDescending(x=> x.AddDate).ToList();
			return View(values);
		}
	}
}
