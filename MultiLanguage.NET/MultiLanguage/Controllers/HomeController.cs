using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultiLanguage.Models.Models;

namespace MultiLanguage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var lang = LanguageHelper.GetCurrentLanguage();
            if(lang == Language.BG)
                ViewBag.Message = "Language is Bulgarian";
            else if(lang == Language.EN)
                ViewBag.Message = "Language is English";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}