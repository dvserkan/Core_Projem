using BusinessLayer.Concrete;
using Core_Projem.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace Core_Projem.ViewComponents.Dashboard
{
	public class AdminNavbarMessageList : ViewComponent
	{

		private readonly UserManager<WriterUser> _userManager;

		WriterMessageManager message = new WriterMessageManager(new EfWriterMessageDal());

		public AdminNavbarMessageList(UserManager<WriterUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			string p = "admin@gmail.com";
			Context c = new Context();

			var values = (from w in c.WriterMessages
						  join a in c.Users
						  on w.SenderName equals a.Name + " " + a.Surname
						  where w.Receiver == "admin@gmail.com"
						  orderby w.WriterMessageID descending
						  select new UserImageMessageModel
						  {
							  ImageUrl = a.ImageUrl,
							  ID = w.WriterMessageID,
							  SenderName = w.SenderName,
							  Date = w.Date
						  })
			  .Take(3)
			  .ToList();

			return View(values);


		}
	}
}
