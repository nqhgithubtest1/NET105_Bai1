namespace NET105_Bai1.Models
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime ManufactureDate { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
