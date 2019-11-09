using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TalkingCat.Models;
using System.Data.Entity;

namespace TalkingCat.Controllers
{
    public class HomeController : Controller
    {
        UserContext db = new UserContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты Book
            IEnumerable<AllUserCat> AllUserCats = db.UserCats;
            // передаем все объекты в динамическое свойство Users в ViewBag
            ViewBag.Users = AllUserCats;
            // возвращаем представление
            return View();
        }
    }
}