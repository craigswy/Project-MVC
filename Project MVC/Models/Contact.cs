using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;

namespace Project_MVC.Models
{
    public class Contact
    {
        public string CName { get; set; }
        public string EName { get; set; }
        public string Email { get; set; }
        public string Tag { get; set; }
        public string Phone { get; set; }
        public string Intro { get; set; }
        public string Character_heading1 { get; set; }
        public string Character_heading2 { get; set; }
        public string Character_heading3 { get; set; }
        public string Character_intro1 { get; set; }
        public string Character_intro2 { get; set; }
        public string Character_intro3 { get; set; }
        public string Job_heading1 { get; set; }

        public DateTime? Job_start1 { get; set; }
        public DateTime? Job_end1 { get; set; }
        public string Job_intro1 { get; set; }
        public string Job_heading2 { get; set; }

        public DateTime? Job_start2 { get; set; }
        public DateTime? Job_end2 { get; set; }
        public string Job_intro2 { get; set; }

        public string Job_heading3 { get; set; }

        public DateTime? Job_start3 { get; set; }
        public DateTime? Job_end3 { get; set; }
        public string Job_intro3 { get; set; }
    }
}