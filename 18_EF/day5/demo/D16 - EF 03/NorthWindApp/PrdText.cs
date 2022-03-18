using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindApp
{
    //[Keyless]
    public class PrdText
    {
        [MaxLength(40)]
        public string ProductName { get; set; }
        [MaxLength(15)]
        public string CategoryName { get; set; }
    }
}
