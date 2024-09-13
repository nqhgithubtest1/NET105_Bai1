using System.ComponentModel.DataAnnotations.Schema;

namespace NET105_Bai1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }

        public ProductDetail ProductDetail { get; set; }

        //[ForeignKey("Category")]
        public int CategoryId { get; set; }

        //[ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
