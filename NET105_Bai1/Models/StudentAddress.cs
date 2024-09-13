using System.ComponentModel.DataAnnotations;

namespace NET105_Bai1.Models
{
    public class StudentAddress
    {
        [Key]
        public int AddressId { get; set; }
        public string AddressDetail { get; set; }


        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
