using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPage.Models.Entity
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string NameSurname { get; set; }
        public string eMail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }


    }
}