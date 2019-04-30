using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.Manager.Base;
using TrainingManagement.Models;

namespace TrainingManagement.Manager.Contract
{
    public interface IStudentManager:IBaseManager<Student>
    {
        ICollection<Student> GetByDepartment(int departmentId);
    }
}
