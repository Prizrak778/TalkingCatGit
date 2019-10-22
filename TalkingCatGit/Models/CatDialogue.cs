using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalkingCat.Models
{
    public class CatDialogue
    {
        //Id Dialogue
        public int Id { get; set; }

        //Id User1
        public int? User1Id { get; set; }
        public AllUserCat User1 { get; set; }

        //Id User2
        public int? User2Id { get; set; }
        public AllUserCat User2 { get; set; }

        //Id Last Message
        public int? LastMessageId { get; set; }


    }
}