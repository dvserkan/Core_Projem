using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.Controllers
{
	public class AdminMessageController : Controller
	{
		WriterMessageManager messageManager = new WriterMessageManager(new EfWriterMessageDal());
		string pa = "admin@gmail.com";
        public IActionResult ReceiverMessageList()
		{
			
			var values = messageManager.GetListReceiverMessage(pa);
			return View(values);
		}

		public IActionResult SenderMessageList()
		{
			
			var values = messageManager.GetListSenderMessage(pa);
			return View(values);
		}

		public IActionResult AdminMessageDetails(int id)
		{
			var values = messageManager.TGetByID(id);
			return View(values);
		}

        [HttpGet]
        public IActionResult AdminMessageSend()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage p)
        {
			Context c = new Context();
			var values = c.Users.Where(x => x.Email == p.Receiver).Select(y => ($"{y.Name} {y.Surname}")).FirstOrDefault();
			p.ReceiverName = values;
			p.Sender = pa;
			p.SenderName = "Admin";
			p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			messageManager.TAdd(p);
            return RedirectToAction("SenderMessageList");
        }

		public IActionResult AdminMessageDelete(int id)
		{
			var values = messageManager.TGetByID(id);
			messageManager.TDelete(values);
			return RedirectToAction("ReceiverMessageList");
		}

    }
}
