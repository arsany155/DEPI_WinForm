using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depi_WinForm
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public string? Location { get; set; }

        public int? Dept_Manager { get; set; }

        public DateTime? HireDate { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<Instructor>? Instructors { get; set; }


        [ForeignKey("Dept_Manager")]
        public Instructor? instructors { get; set; }

    }
}
