using demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;

namespace demo.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", CategoryId = 2, Price = "1" },
            new Product { Id = 2, Name = "Yo-yo", CategoryId = 1, Price = "6" },
            new Product { Id = 3, Name = "Milk", CategoryId = 1, Price = "16" }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
        [Route("api/getproductbycategory/{categoryid}")]
        public IHttpActionResult GetProductByCategory(int categoryId)
        {
            var product = products.Where(products => products.CategoryId == categoryId);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpPost]
        public IHttpActionResult PostProduct(Product product)
        {
            return Ok(product);
        }

    }
}
