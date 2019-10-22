using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TalkingCat.Models
{
    public class UserContext : DbContext
    {
        public DbSet<AllUserCat> UserCats { get; set; }
        public DbSet<CatDialogue> catDialogues { get; set; }
        public DbSet<UserCatMessage> userCatMessages { get; set; }

    }
}