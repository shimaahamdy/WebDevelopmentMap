using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CustomerOrders.Models
{

    [Table("Orders")]
    public class Order
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "price is required")]
        public decimal TotalPrice { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }

        [ForeignKey("Customer")]
        public int CusID { get; set; }

        public Customer Customer { get; set; }
    }
}