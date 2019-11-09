using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalkingCat.Models
{
    public class CatAlbum
    {
        //Id Img
        public int Id { get; set; }

        //Name
        public string NameAlbum { get; set; }

        //Imgs
        public virtual ICollection<CatImg> CatImgs { get; set; }
        public virtual ICollection<AllUserCat> CatUsers { get; set; }

        public CatAlbum()
        {
            CatUsers = new List<AllUserCat>();
            CatImgs = new List<CatImg>();
        }
    }
}