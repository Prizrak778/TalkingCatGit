using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TalkingCat.Models
{
    public class UserDbInitializer : DropCreateDatabaseAlways<UserContext>
    {
        //Это добавление сделано просто для тестов, можно менять как хочется(с учетом моделей, конечно)
        protected override void Seed(UserContext db)
        {
            AllUserCat user1 = new AllUserCat { Name = "Vladimir", SurName = "Merkel", Birthday = DateTime.Now, AboutMe = "1", CurrentCity = "1", CurrentCountry = "1", Language = "1", SecondName = "1", Status = "1", UrlLink = "1", LastActivity = DateTime.Parse("12/10/2019 19:25:00") };
            AllUserCat user2 = new AllUserCat { Name = "BBBBBBBB", SurName = "22222222", Birthday = DateTime.Parse("12/09/1995"), LastActivity = DateTime.Parse("12/10/2019 19:25:00") };
            AllUserCat user3 = new AllUserCat { Name = "CCCCCCCC", SurName = "3333333", Birthday = DateTime.Parse("12/12/2007"), LastActivity = DateTime.Parse("12/10/2019 19:25:00") };

            CatImg Img1 = new CatImg { User = user1, DateDownload = DateTime.Parse("24/12/2007"), PathImg = "~/Content/Images/Album/photo_2019-09-17_20-59-39.jpg" };
            CatImg Img2 = new CatImg { User = user1, DateDownload = DateTime.Parse("24/12/2007"), PathImg = "~/Content/Images/Album/photo_2019-10-22_18-47-00.jpg" };
            CatImg Img3 = new CatImg { User = user1, DateDownload = DateTime.Parse("24/12/2007"), PathImg = "~/Content/Images/Album/мя.jpg" };

            db.UserCats.Add(user1);
            db.UserCats.Add(user2);
            db.UserCats.Add(user3);

            db.CatImgs.Add(Img1);
            db.CatImgs.Add(Img2);
            db.CatImgs.Add(Img3);

            CatDialogue dialog1 = new CatDialogue { User1 = user1, User2 = user2, LastMessageId = 2 };
            db.catDialogues.Add(dialog1);

            CatAlbum album1 = new CatAlbum { CatUsers = new List<AllUserCat> { user1, user2 }, NameAlbum = "Test", CatImgs = new List<CatImg> { Img1, Img2, Img3 } };
            db.CatAlbums.Add(album1);

            db.userCatMessages.Add(new UserCatMessage { Message = "1", DateMessage = DateTime.Parse("12/09/2019 13:40:58"), AuthorMessageId = 1, DialogId = 1 });
            db.userCatMessages.Add(new UserCatMessage { Message = "2", DateMessage = DateTime.Parse("12/09/2019 13:41:58"), AuthorMessageId = 2, DialogId = 1 });



            base.Seed(db);
        }
    }
}