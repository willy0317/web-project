using System;
using System.Collections.Generic;
namespace web_final.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }


    }
}
