using demo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace demo.Controllers
{
    public class CategoryController : ApiController
    {
        category[] categorys = new category[]
        {
            new category { Id = 1, Name = "Food"},
            new category { Id = 2, Name = "Drink"}
        };
        public IEnumerable<category> GetAllProducts()
        {
            return categorys;
        }
        public IHttpActionResult GetCategory(int id)
        {
            var category = categorys.FirstOrDefault((p) => p.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
    }
}
