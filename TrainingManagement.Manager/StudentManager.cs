using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.Manager.Base;
using TrainingManagement.Manager.Contract;
using TrainingManagement.Models;
using TrainingManagement.Repositories.Base;
using TrainingManagement.Repositories.Contract;

namespace TrainingManagement.Manager
{
    public class StudentManager:BaseManager<Student>,IStudentManager
    {
        private IStudentRepository _studentRepository;
        public StudentManager(IStudentRepository repository) : base(repository)
        {
            _studentRepository = repository;
        }

        public ICollection<Student> GetByDepartment(int departmentId)
        {
            return _studentRepository.GetByDepartment(departmentId);
        }
    }
}
