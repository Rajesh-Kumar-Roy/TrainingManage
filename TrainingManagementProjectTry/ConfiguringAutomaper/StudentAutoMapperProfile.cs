using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TrainingManagement.Models;
using TrainingManagementProjectTry.Models;
using TrainingManagementProjectTry.Models.StudentViewModel;

namespace TrainingManagementProjectTry.ConfiguringAutomaper
{
    public class StudentAutoMapperProfile:Profile
    {
        public StudentAutoMapperProfile()
        {
            CreateMap<Student, StudentCreateViewModel>();
            CreateMap<StudentCreateViewModel,Student>();
            CreateMap<Department, DepartmentViewModel>();
            CreateMap<DepartmentViewModel, Department>();


        }
    }
}
