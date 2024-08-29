using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depi_WinForm
{
    public class Instructor_Course
    {
        public int InsId { get; set; }

        public int CrsId { get; set; }
        public string? Evaluation { get; set; }

        [ForeignKey("InsId")]
        public Instructor Instructor { get; set; }


        [ForeignKey("CrsId")]
        public Course Course { get; set; }

    }
}
