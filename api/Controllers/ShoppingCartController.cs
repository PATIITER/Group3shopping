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
    public class ShoppingCartController : ControllerBase
    {
        public static List<Cart> Cart = new List<Cart>
        {
            // new Product{
            //     Id = Guid.NewGuid().ToString(),
            //     ProductName ="ดินสอ",
            //       Price = 5,
            //       Pieces = "https://dxxt5i7fka2g1.cloudfront.net/media/catalog/product/O/F/OFM1502780.jpg"
            // },
            // new Product{
            //     Id = Guid.NewGuid().ToString(),
            //     ProductName ="ไม้บรรทัด",
            //       Price = 15,
            //       Pieces = "https://www.goodchoiz.com/content/images/thumbs/0035572_%E0%B9%89%E0%B8%B1%E0%B9%87-%E0%B8%B4%E0%B9%8C-12_550.jpeg"
            // },
            // new Product{
            //     Id = Guid.NewGuid().ToString(),
            //     ProductName ="ยางลบ",
            //       Price = 10,
            //       Pieces = "https://ssfortunetrade.co.th/wp-content/uploads/2018/09/46.-Eraser-Quantum-QE600.jpg"
            // },

        };
        [HttpGet]
        public List<Cart> GetAll()
        {
            return Cart;
        }

        [HttpPost]
        // เพิ่มสินค้าในตะกร้า
        public void Create([FromBody]Cart newCart)
        {
            newCart.Id = Guid.NewGuid().ToString();
            Cart.Add(newCart);
        }

        [HttpPut]
        // แก้ไขรายการในตะกร้าสินค้า
        public void Update([FromBody]Cart newCart)
        {
            var oldCart = Cart.Find(it => it.Id == newCart.Id);
            Cart.Remove(oldCart);
            Cart.Add(newCart);
        }
        
        [HttpDelete("{id}")]
        // ลบสินค้าในตะกร้า
        public void Delete(string id)
        {
            var carts = Cart.Find(it => it.Id == id);
            Cart.Remove(carts);
        }
    }
}
