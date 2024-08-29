using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depi_WinForm
{
    public  class Topic
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public ICollection<Course>? Courses { get; set;}
    }
}
