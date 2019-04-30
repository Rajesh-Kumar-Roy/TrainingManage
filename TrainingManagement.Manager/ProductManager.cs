using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.Manager.Base;
using TrainingManagement.Manager.Contract;
using TrainingManagement.Models;
using TrainingManagement.Repositories.Contract;

namespace TrainingManagement.Manager
{
    public class ProductManager:BaseManager<Product>,IProductManager
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository):base(productRepository)
        {
            _productRepository = productRepository;
        }
    }
}
