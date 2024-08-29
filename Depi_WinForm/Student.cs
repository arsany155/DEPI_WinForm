using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depi_WinForm
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string? First_Name { get; set; }

        public string? Last_Name { get; set;}

        public string? Address { get; set; }

        public byte? Age { get; set; }


        public int? DeptId { get; set; }


        [ForeignKey("DeptId")]
        public Department? department { get; set; }

        public ICollection<Student_Course> Student_Courses { get; set; }
    }
}
