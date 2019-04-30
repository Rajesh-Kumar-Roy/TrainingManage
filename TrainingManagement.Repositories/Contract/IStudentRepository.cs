using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.Models;
using TrainingManagement.Repositories.Base;

namespace TrainingManagement.Repositories.Contract
{
     public interface IStudentRepository:IBaseRepository<Student>
     {
         ICollection<Student> GetByDepartment(int departmentId);
     }
}
