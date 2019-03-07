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
                  Pieces = "https://dxxt5i7fka2g1.cloudfront.net/media/catalog/product/O/F/OFM1502780.jpg"
            },
            new Product{
                Id = Guid.NewGuid().ToString(),
                ProductName ="ไม้บรรทัด",
                  Price = 15,
                  Pieces = "https://www.goodchoiz.com/content/images/thumbs/0035572_%E0%B9%89%E0%B8%B1%E0%B9%87-%E0%B8%B4%E0%B9%8C-12_550.jpeg"
            },
            new Product{
                Id = Guid.NewGuid().ToString(),
                ProductName ="ยางลบ",
                  Price = 10,
                  Pieces = "https://ssfortunetrade.co.th/wp-content/uploads/2018/09/46.-Eraser-Quantum-QE600.jpg"
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
