using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopConsumer.Models
{
    public class Course
     {
        public int Crs_Id { get; set; }
        public string Crs_Name { get; set; }
        public Nullable<int> Crs_Duration { get; set; }
        public Nullable<int> Top_Id { get; set; }

        //public Topic Topic { get; set; }
        
    }
}
