using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TrainingManagement.Models;
using TrainingManagement.Repositories.Base;
using TrainingManagement.Repositories.Contract;
using TrainingManangement.DbContext.DataBaseContext;

namespace TrainingManagement.Repositories
{
    public class CourseRepository:BaseRepository<Course>,ICourseRepository
    {
        public CourseRepository(DbContext db) : base(db)
        {
        }

        public TrainingDbContext Context
        {
            get { return (TrainingDbContext) db; }
        }
    }
}
