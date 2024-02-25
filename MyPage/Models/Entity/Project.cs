using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPage.Models.Entity
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Date { get; set; }
        public string Url { get; set; }

    }
}