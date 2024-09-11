namespace NET105_Bai1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
