﻿using Microsoft.AspNetCore.Mvc;

namespace Core_Projem.Areas.Writer.Controllers
{
	public class MessageController : Controller
	{
		[Area("Writer")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
