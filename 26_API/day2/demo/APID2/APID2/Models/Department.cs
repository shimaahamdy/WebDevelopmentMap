using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace APID2.Models
{
   // [DataContract]
    public class Department
    {
        public Department()
        {
            Students = new List<student>();
        }
      //  [DataMember]
        public int id { get; set; }
       // [DataMember]

        public string name { get; set; }
        public string location { get; set; }

       // [JsonIgnore]
        public virtual List<student> Students { get; set; }
    }
}