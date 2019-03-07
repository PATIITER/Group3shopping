using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public static List<Product> Product = new List<Product>
        {
            new Product{
                Id = Guid.NewGuid().ToString(),
                ProductName ="ดินสอ",
                  Price = 5,
                  Pieces = 0
            },
            new Product{
                Id = Guid.NewGuid().ToString(),
                ProductName ="ไม้บรรทัด",
                  Price = 15,
                  Pieces = 0
            },
            new Product{
                Id = Guid.NewGuid().ToString(),
                ProductName ="ยางลบ",
                  Price = 10,
                  Pieces = 0
            },

        };
        [HttpGet]
        public List<Product> GetAllProducts(){
            return Product;
        }

         [HttpGet("{id}")]
        public Product GetProductbyId(string id){
            return Product.Find(it=>it.Id==id);
        }

        [HttpPost]
        public  void CreateProduct([FromBody]Product newProduct) {
            newProduct.Id = Guid.NewGuid().ToString();
            Product.Add(newProduct);
        }
          [HttpPut]
        public  void UpdateProduct([FromBody]Product newProduct) {
           
            var oldProduct= Product.Find(it=>it.Id==newProduct.Id);
            Product.Remove(oldProduct);
            Product.Add(newProduct);
        }
     }
}
