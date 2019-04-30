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
    public class DepartmentManager:BaseManager<Department>,IDepartmentManager
    {
        private IDepartmentRepository _departmentRepository;
        public DepartmentManager(IDepartmentRepository repository ) : base(repository)
        {
            _departmentRepository = repository;
        }
    }
}
