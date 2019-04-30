using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrainingManagement.Models
{
    public class Student
    {
        //public Student()
        //{
        //    DepartmentId = 1;
        //}
        public int Id { get; set; }
        public string Name { get; set; }    
        public string RegNo { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
