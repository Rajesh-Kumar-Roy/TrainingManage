using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using TrainingManangement.DbContext.DataBaseContext;

namespace TrainingManagement.Repositories.Base
{
    public abstract class BaseRepository<T> :IBaseRepository<T> where T:class
    {
        protected DbContext db;
        protected BaseRepository(DbContext db)
        {
            this.db = db;
        }

        public DbSet<T> Table {  get{return db.Set<T>();} }
        public virtual bool Add(T entity)
        {
            Table.Add(entity);
            return db.SaveChanges() > 0;
        }

        public virtual bool Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public virtual bool Remove(T entity)
        {
            Table.Remove(entity);
          return  db.SaveChanges() > 0;
        }

        public virtual T GetById(int id)
        {
            return Table.Find(id);
        }

        public virtual ICollection<T> GetAll()
        {
            return Table.ToList();
        }
    }
}
