﻿using System.Diagnostics.Metrics;

namespace web_final.Models
{
public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public  Course Course { get; set; }
        public Member Member { get; set; }
    }
}

