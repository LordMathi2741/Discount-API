using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraestructure;
using Infraestructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1._Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductFactory _productType;
        private static List<Product> _info = new List<Product>();
        public ProductController(IProductFactory productType)
        {
            _productType = productType;
            
        }
        // GET: api/Product
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _productType.GetAll(_info).Select(x => x.Type).ToList();
        }

        // POST: api/Product
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            _productType.Save(product, _info);
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
