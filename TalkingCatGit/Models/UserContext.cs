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

        public DbSet<CatAlbum> CatAlbums { get; set; }

        public DbSet<CatImg> CatImgs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatAlbum>().HasMany(c => c.CatUsers)
                .WithMany(s => s.CatAlbums)
                .Map(t => t.MapLeftKey("CatAlbum_Id")
                .MapRightKey("CatUser_Id")
                .ToTable("CatAlbumAllUserCat"));
            modelBuilder.Entity<CatAlbum>().HasMany(c => c.CatImgs)
                .WithMany(s => s.CatAlbums)
                .Map(t => t.MapLeftKey("CatImg_Id")
                .MapRightKey("CatAlbum_Id")
                .ToTable("CatImgCatAlbums"));
        }
    }
}