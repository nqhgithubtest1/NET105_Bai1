using System.ComponentModel.DataAnnotations.Schema;

namespace NET105_Bai1.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("CategoryId")]
        public ICollection<Product> Products { get; set; }
    }
}
