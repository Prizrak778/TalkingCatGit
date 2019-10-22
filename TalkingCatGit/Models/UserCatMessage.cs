using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalkingCat.Models
{
    public class UserCatMessage
    {
        //Id Message
        public int Id { get; set; }

        //Message
        public string Message { get; set; }

        //Date Message
        public DateTime DateMessage { get; set; }

        public int DialogId { get; set; }

        //Id Author Message
        public int AuthorMessageId { get; set; }
    }
}