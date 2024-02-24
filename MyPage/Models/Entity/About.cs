using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPage.Models.Entity
{
    public class About
    {
        public int AboutID { get; set; }
        public string Header { get; set; }
        public string Title { get; set; }
        public String NameSurname { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrlTwo { get; set; }
        public string Description { get; set; }
        public string DescriptionSmall { get; set; }

    }
}