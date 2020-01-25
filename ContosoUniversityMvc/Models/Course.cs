namespace ContosoUniversityMvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { set; get; }
        public string Title { set; get; }
        public int Credits { set; get; }

        public ICollection<Enrollment> Enrollments { set; get; }
    }
}
