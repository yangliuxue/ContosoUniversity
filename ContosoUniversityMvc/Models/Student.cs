namespace ContosoUniversityMvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class Student
    {
        public string ID { set; get; }
        public string LastName { set; get; }
        public string FirstMidName { set; get; }
        public DateTime EnrollmentDate { set; get; }

        public ICollection<Enrollment> Enrollments { set; get; }
    }
}
