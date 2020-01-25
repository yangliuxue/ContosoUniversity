using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversityMvc.Models
{
    public class Enrollment
    {
        public int EnrollmentID { set; get; }
        public int CourseID { set; get; }
        public int StudentID { set; get; }
        public Grade? Grade { set; get; }

        public Student Student { set; get; }
        public Course Course { set; get; }
    }

    public enum Grade
    {
        A,B,C,D,F
    }
}
