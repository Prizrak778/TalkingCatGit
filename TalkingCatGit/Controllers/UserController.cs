using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TalkingCat.Models;
using System.Data.Entity;

namespace TalkingCat.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        UserContext db = new UserContext();

        public ActionResult UserCat(int? Id)
        {
            int UserCatId = Id ?? 1;
            AllUserCat UserCat = db.UserCats.Where(x => x.Id == UserCatId).FirstOrDefault();
            var catImgs = db.CatImgs.Where(x => x.User.Id == UserCatId);
            if (UserCat != null)
            {
                var UserDialogues = db.catDialogues.Include(x => x.User1).Include(x => x.User2);
                ViewBag.User = UserCat;
                ViewBag.Dialog = UserDialogues.ToList();
                ViewBag.Img = UserCat.AvatarImgId == null ? Url.Content("~/Content/Images/Standart.png") : Url.Content("~/Content/Images/Standart.png");
                ViewBag.Online = (DateTime.Now - UserCat.LastActivity).Value.Ticks < new DateTime(600000000).Ticks ? "online" : (DateTime.Now - UserCat.LastActivity).Value.Ticks < new DateTime(6000000000).Ticks ? "Был(а)" + (DateTime.Now - UserCat.LastActivity).Value.Minutes.ToString() + "Минуты назад" : "Последная активность была " + UserCat.LastActivity.ToString();
                if (catImgs != null)
                {
                    ViewBag.MyImgsCount = catImgs.Count();
                    ViewBag.MyImgs = catImgs.ToList().GetRange(0, catImgs.Count() < 4 ? catImgs.Count() : 4);
                }

            }
            return View();
        }
    }
}