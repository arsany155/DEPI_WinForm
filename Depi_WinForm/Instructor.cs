using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depi_WinForm
{
    public class Instructor
    {
        [Key]
        public int InsId { get; set; }
        public string? Name { get; set; }

        public string? InsDegree { get; set; }

        public  decimal?  Salary { get; set; }

        public int? DeptId { get; set; }



        [ForeignKey("DeptId")]
        public Department? department { get; set; }  

        public ICollection<Department> Departments { get; set; }


        public ICollection<Instructor_Course> Instructor_Courses { get; set; }
    }
}
