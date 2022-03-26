using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APID2.Models
{
    public class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        [ForeignKey("department")]
        public int  deptid { get; set; }
        public virtual Department department { get; set; }
    }
}