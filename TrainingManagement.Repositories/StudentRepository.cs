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
   public class StudentRepository:BaseRepository<Student>,IStudentRepository
   {
       public TrainingDbContext Context
       {
           get { return (TrainingDbContext) db; }
       }

       public StudentRepository(DbContext db) : base(db)
        {
            this.db = (TrainingDbContext) db;
        }

       public ICollection<Student> GetByDepartment(int departmentId)
       {
          return  Context.Students.Where(c => c.DepartmentId == departmentId).ToList();
       }
   }
}
