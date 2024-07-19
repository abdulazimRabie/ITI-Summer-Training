using System.ComponentModel.DataAnnotations;

namespace EF_Linq.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public decimal Price { get; set; }
        
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
