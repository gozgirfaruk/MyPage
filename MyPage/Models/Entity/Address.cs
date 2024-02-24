using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPage.Models.Entity
{
    public class Address
    {
        public int AddressID { get; set; }
        public string Header { get; set; }
        public string eMail { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string İmageUrl { get; set; }
    }
}