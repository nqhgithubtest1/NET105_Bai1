﻿namespace NET105_Bai1.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
