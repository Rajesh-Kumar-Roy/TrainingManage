using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingManagement.Models;

namespace TrainingManagementProjectTry.Models
{
    public class DepartmentViewModel
    {
        public string Name { get; set; }
        public string shortName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
