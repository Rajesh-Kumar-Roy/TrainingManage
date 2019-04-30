using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TrainingManagement.Manager;
using TrainingManagement.Manager.Contract;
using TrainingManagement.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TrainingManagementProjectTry.Controllers.API
{
     [Route("api/products")]
     [EnableCors("AllowOrigin")]
    public class ProductController : Controller
    {
        private IProductManager _productManager;

        public ProductController(IProductManager productManager)
        {
            _productManager = productManager;

        }
       
        [HttpGet()]
        public IActionResult Get()
        {
            var products = _productManager.GetAll();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _productManager.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        public IActionResult Post([FromBody] Product product)
        {
            if (ModelState.IsValid)
            {
                bool isAdded= _productManager.Add(product);
                return Ok(product);
            }

            return BadRequest();

        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Product product)
        {
          var retriveProduct= _productManager.GetById(id);
          if (retriveProduct == null)
          {
              return BadRequest(new {error="Product is Not found!"});
          }

          retriveProduct.Name = product.Name;
          retriveProduct.Price = product.Price;
          bool isAdded=     _productManager.Update(retriveProduct);
          if (isAdded)
          {
              return Ok(retriveProduct);
          }

          return BadRequest(new {error = "Update failed!!"});

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var retriveprodut=_productManager.GetById(id);
            if (retriveprodut == null)
            {
                return BadRequest(new {error = "Not found"});
            }

            bool isDelete = _productManager.Remove(retriveprodut);
            if (isDelete)
            {
                return Ok();
            }

            return BadRequest(new {error = "Failed"});
        }

    }
}
