using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.Repositories.Base;

namespace TrainingManagement.Manager.Base
{
    public abstract class BaseManager<T>:IBaseManager<T> where T:class
    {
        private IBaseRepository<T> _baseRepository;

        public BaseManager(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public virtual bool Add(T entity)
        {
            return _baseRepository.Add(entity);
        }

        public virtual bool Update(T entity)
        {
            return _baseRepository.Update(entity);

        }

        public virtual bool Remove(T entity)
        {
            return _baseRepository.Remove(entity);
        }

        public virtual T GetById(int id)
        {
            return _baseRepository.GetById(id);
        }

        public virtual ICollection<T> GetAll()
        {
            return _baseRepository.GetAll();
        }
    }
}
