using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrainingManagement.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public virtual List<Student> Students { get; set; }
    }
}
