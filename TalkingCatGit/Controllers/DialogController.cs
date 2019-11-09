using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TalkingCat.Models;
using System.Data.Entity;

namespace TalkingCat.Controllers
{
    public class DialogController : Controller
    {
        UserContext db = new UserContext();
        // GET: Dialog
        public ActionResult CatDialog(int? Id, int? idUser)
        {
            int DialogId = Id ?? 0;
            int UserId = idUser ?? 0;
            CatDialogue CatDialog = db.catDialogues.Where(x => x.Id == DialogId).FirstOrDefault();
            AllUserCat UserCat;
            if (CatDialog != null)
            {
                if (idUser == CatDialog.User1Id)
                {
                    UserCat = db.UserCats.Where(x => x.Id == CatDialog.User2Id).FirstOrDefault();
                }
                else
                {
                    UserCat = db.UserCats.Where(x => x.Id == CatDialog.User1Id).FirstOrDefault();
                }
                IEnumerable<UserCatMessage> UserCatMessage = db.userCatMessages.Where(x => x.DialogId == DialogId).Include(x => x.AuthorMessage);
                ViewBag.UserMessages = UserCatMessage;
                ViewBag.User = UserCat;
            }
            return View();
        }
    }
}