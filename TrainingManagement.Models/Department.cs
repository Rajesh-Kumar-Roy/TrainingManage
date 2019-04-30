using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingManagement.Models
{
    public class Department
    {
        public Department()
        {
            Students=new List<Student>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string shortName { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
