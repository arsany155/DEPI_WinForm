using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depi_WinForm
{
    public class Student_Course
    {
        [ForeignKey("Course")]
        public int CrsId { get; set; }

        [ForeignKey("Student")]
        public int StId { get; set; }

        public int? Grade { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
