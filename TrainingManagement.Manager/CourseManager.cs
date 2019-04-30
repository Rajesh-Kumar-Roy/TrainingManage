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
    public class CourseManager:BaseManager<Course>,ICourseManager
    {
        private ICourseRepository _courseRepository;
        public CourseManager(ICourseRepository repository) : base(repository)
        {
            _courseRepository = repository;
        }
    }
}
