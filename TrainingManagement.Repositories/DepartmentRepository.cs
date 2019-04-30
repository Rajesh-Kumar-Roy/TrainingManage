using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TrainingManagement.Models;
using TrainingManagement.Repositories.Base;
using TrainingManagement.Repositories.Contract;
using TrainingManangement.DbContext.DataBaseContext;

namespace TrainingManagement.Repositories
{
    public class DepartmentRepository:BaseRepository<Department>,IDepartmentRepository
    {
        public TrainingDbContext Context
        {
            get { return (TrainingDbContext) db; }
        }

        public DepartmentRepository(DbContext db) : base(db)
        {
          
        }

        public override ICollection<Department> GetAll()
        {
            return Context.Departments.Include(c => c.Students).ToList();
        }
    }
}
