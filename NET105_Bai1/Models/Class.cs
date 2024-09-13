namespace NET105_Bai1.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
