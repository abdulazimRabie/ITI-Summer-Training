using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EF_Linq.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public string Address { get; set; }
        
        public ICollection<Order> Orders { get; set; }
    }
}
