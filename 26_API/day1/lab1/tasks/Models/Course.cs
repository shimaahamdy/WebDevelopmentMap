using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tasks.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
    }
}