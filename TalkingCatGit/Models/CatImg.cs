using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TalkingCat.Models
{
    public class CatImg
    {
        //Id Img
        public int Id { get; set; }

        //Id Author
        public int UserId { get; set; }

        public AllUserCat User { get; set; }

        //Data download img
        public DateTime DateDownload { get; set; }

        //Path img
        public string PathImg { get; set; }

        //Albums

        public virtual ICollection<CatAlbum> CatAlbums { get; set; }
        public CatImg()
        {
            CatAlbums = new List<CatAlbum>();
        }
    }
}