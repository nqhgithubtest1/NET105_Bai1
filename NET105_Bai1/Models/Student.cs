using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NET105_Bai1.Models
{
    [Table("SinhVien")]
    public class Student
    {
        // khoa chinh
        [Key]
        public int StudentId { get; set; }

        // bat buoc, not null
        [Required(ErrorMessage = "Ten bat buoc phai dien")]
        // do dai chuoi
        [StringLength(50, ErrorMessage = "Ten khong the dai hon 50 ky tu")]
        public string Name { get; set; }

        // khoang gia tri
        [Range(18, 50)]
        public int Age { get; set; }

        // validate cho truong email
        [EmailAddress]
        public string Email { get; set; }

        // validate cho truong phone
        [Phone]
        //[RegularExpression(@"(84|0[3|5|7|8|9])+([0-9]{8})")]
        public string Phone { get; set; }

        [Range(typeof(DateTime), "1/1/0001", "12/31/9999")]
        public DateTime DOB { get; set; }


        public StudentAddress StudentAddress { get; set; }

        public int ClassId { get; set; }
        public Class Class { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
