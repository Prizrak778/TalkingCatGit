using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TalkingCat.Models
{
    public class UserDbInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            db.UserCats.Add(new AllUserCat { Name= "Vladimir", SurName= "Merkel", Birthday=DateTime.Now, AboutMe="1", CurrentCity="1", CurrentCountry="1", Language="1", SecondName="1", Status="1", UrlLink="1", LastActivity = DateTime.Parse("12/10/2019 19:25:00") });
            db.UserCats.Add(new AllUserCat { Name = "BBBBBBBB", SurName = "22222222", Birthday = DateTime.Parse("12/09/1995") });
            db.UserCats.Add(new AllUserCat { Name = "CCCCCCCC", SurName = "3333333", Birthday = DateTime.Parse("12/12/2007") });

            db.catDialogues.Add(new CatDialogue { User1Id = 1, User2Id = 2, LastMessageId = 2});

            db.userCatMessages.Add(new UserCatMessage { Message = "1", DateMessage = DateTime.Parse("12/09/2019 13:40:58"), AuthorMessageId = 1, DialogId = 1 });
            db.userCatMessages.Add(new UserCatMessage { Message = "2", DateMessage = DateTime.Parse("12/09/2019 13:41:58"), AuthorMessageId = 2, DialogId = 1 });

            base.Seed(db);
        }
    }
}