using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPage.Models.Entity
{
    public class Education
    {
        public int EducationID { get; set; }
        public string Header { get; set; }
        public string SchoolName { get; set; }
        public string Degree { get; set; }
        public string Description { get; set; }
    }
}