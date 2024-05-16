using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2._Domain;
using Humanizer.DateTimeHumanizeStrategy;
using Infraestructure;
using Infraestructure.Models;
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
        private static List<string> _info = new List<string>();
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
            return _info;
        }
        

        // POST: api/Discount
        [HttpPost]
        public void Post([FromBody] ProductAndMembership productAndMembership)
        {
            var isDiscountApplicable = _discount.CheckDiscount(productAndMembership.Product, productAndMembership.Membership);
            if (isDiscountApplicable)
            {
                _discount.ApplyDiscount(productAndMembership.Product, productAndMembership.Membership);
            }
            _info.Add($"Product: {productAndMembership.Product.Type}, Price: {productAndMembership.Product.Price}");
            _info.Add($"Membership: {productAndMembership.Membership.Type}");
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
