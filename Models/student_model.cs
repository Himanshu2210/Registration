using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registration.Models
{
    public class student_model
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public string city { get; set; }
        public string gender { get; set; }
        public string gender1 { get; set; }
        public string psw { get; set; }
        public string cnfpsw { get; set; }
    }
}