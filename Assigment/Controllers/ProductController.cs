using Assigment1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assigment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Context _context;
        public ProductController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Products);
            }
            catch (Exception)
            {

                return StatusCode(500, "Server error.");
            }

        }

        [HttpPost]
        public IActionResult Save(Product product)
        {
            try
            {
                var prd = new Product() { Name = "Product" };
                _context.Products.Add(prd);
                _context.SaveChanges();
                return Ok("Success");
            }
            catch (Exception)
            {
                return StatusCode(500, "Server error.");

            }
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Product product)
        {
            try
            {
                var query = (from e in _context.Products where e.Id == id select e);
                Product original = query.SingleOrDefault();

                original.Name = product.Name;
                _context.SaveChanges();
                return Ok("Success");
            }
            catch (Exception)
            {
                return StatusCode(500, "Server error.");

            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var query = (from e in _context.Products where e.Id == id select e);
                Product product = query.SingleOrDefault();
                _context.Products.Remove(product);
                _context.SaveChanges();
                return Ok("Success");
            }
            catch (Exception)
            {
                return StatusCode(500, "Server error.");

            }
        }
    }
}
