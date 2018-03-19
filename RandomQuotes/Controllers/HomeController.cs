using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RandomQuotes.Models;

namespace RandomQuotes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var quote = Quote.GetRandomQuote();
            return View(quote);
        }

        [HttpPost]
        public ActionResult ReloadPage()
        {
            return RedirectToAction("Index");
        }
    }
}