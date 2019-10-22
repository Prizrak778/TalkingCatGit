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

        [HttpGet]
        public ActionResult UserCat(int? Id)
        {
            int UserCatId = Id ?? 1;
            AllUserCat UserCat = db.UserCats.Where(x => x.Id == UserCatId).FirstOrDefault();
            if (UserCat != null)
            {
                var UserDialogues = db.catDialogues.Include(x => x.User1).Include(x => x.User2);
                ViewBag.User = UserCat;
                ViewBag.Dialog = UserDialogues.ToList();
                ViewBag.Img = UserCat.ImgId == null ? Url.Content("~/Content/Images/Standart.png") : Url.Content("~/Content/Images/Standart.png");
                ViewBag.Online = (DateTime.Now - UserCat.LastActivity).Value.Ticks < new DateTime(600000000).Ticks ? "online" : (DateTime.Now - UserCat.LastActivity).Value.Ticks < new DateTime(6000000000).Ticks ? "Был(а)" + (DateTime.Now - UserCat.LastActivity).Value.Minutes.ToString() + "Минуты назад" : "Последная активность была " + UserCat.LastActivity.ToString();
            }
            return View();
        }

        [HttpGet]
        public ActionResult CatDialog(int? Id, int? idUser)
        {   
            int DialogId = Id ?? 0;
            int UserId = idUser ?? 0;
            CatDialogue CatDialog = db.catDialogues.Where(x => x.Id == DialogId).FirstOrDefault();
            AllUserCat UserCat;
            if (CatDialog != null)
            {
                if(idUser == CatDialog.User1Id)
                {
                    UserCat = db.UserCats.Where(x => x.Id == CatDialog.User2Id).FirstOrDefault();
                }
                else
                {
                    UserCat = db.UserCats.Where(x => x.Id == CatDialog.User1Id).FirstOrDefault();
                }
                IEnumerable<UserCatMessage> UserCatMessage = db.userCatMessages.Where(x => x.DialogId == DialogId);
                ViewBag.UserMessages = UserCatMessage;
                ViewBag.User = UserCat;
            }
            return View();
        }
    }
}