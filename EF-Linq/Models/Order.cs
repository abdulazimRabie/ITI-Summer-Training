using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Linq.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        
        public DateTime OrderDate { get; set; }
        
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        
        public Customer Customer { get; set; }
        
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
