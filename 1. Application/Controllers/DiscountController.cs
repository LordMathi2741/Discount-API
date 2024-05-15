using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2._Domain;
using Infraestructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1._Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private IDiscountDomain _discount;
        private IMemberShipFactory _memberShip;
        private IProductFactory _productType;
        public DiscountController(IDiscountDomain _discount, IMemberShipFactory _memberShip, IProductFactory _product)
        {
            this._discount = _discount;
            this._memberShip = _memberShip;
            this._productType = _product;
        }
        // GET: api/Discount
        [HttpGet]
        public IEnumerable<string> Get()
        {
            List<string> info = new List<string>();
            var productTypes = _productType.GetAll().Select(x => x.Type).ToList();
            var memberShipTypes = _memberShip.GetAll().Select(x => x.Type).ToList();
            info.AddRange(productTypes);
            info.AddRange(memberShipTypes);
            return info;
        }
        

        // POST: api/Discount
        [HttpPost]
        public void Post([FromBody] string value)
        {
            
            
        }

        // PUT: api/Discount/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Discount/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
