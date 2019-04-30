using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using TrainingManagement.Models;

namespace TrainingManagementProjectTry.Models.StudentViewModel
{
    public class StudentCreateViewModel
    {
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<SelectListItem> DepartLoopupdata { get; set; }
        public ICollection<Student> studentcollection { get; set; }
    }
}
