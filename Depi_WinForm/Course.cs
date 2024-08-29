using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depi_WinForm
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public int? Crs_Duration { get; set; }


        [ForeignKey("Topic")]
        public int? TopicId { get; set; }

        public Topic? Topic { get; set; }

        public ICollection<Student_Course> Student_Courses { get; set; }

        public ICollection<Instructor_Course> Instructor_Courses { get; set; }
    }
}
