using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.Models;
using TrainingManagement.Repositories.Base;

namespace TrainingManagement.Repositories.Contract
{
    public interface IProductRepository:IBaseRepository<Product>
    {
    }
}
