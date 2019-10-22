using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TalkingCat.Models
{
    public class AllUserCat
    {
        //Id User
        public int Id { get; set; }

        //FirstName User
        public string Name { get; set; }

        //Surname
        public string SurName { get; set; }

        //Second name
        public string SecondName { get; set; }

        //Birthday
        public DateTime? Birthday { get; set; }

        //Current City
        public string CurrentCity { get; set; }

        //Current Country
        public string CurrentCountry { get; set; }

        //Language
        public string Language { get; set; }

        //UrlLink
        public string UrlLink { get; set; }

        //Status
        public string Status { get; set; }

        //About Me
        public string AboutMe { get; set; }

        public DateTime? LastActivity { get; set; }

        public int? ImgId { get; set; }

        public ICollection<CatDialogue> CatDialogues { get; set; }

        public AllUserCat()
        {
            CatDialogues = new List<CatDialogue>();
        }
    }
}