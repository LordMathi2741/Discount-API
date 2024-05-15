using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1._Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberShipController : ControllerBase
    {
        // GET: api/MemberShip
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        

        // POST: api/MemberShip
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/MemberShip/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/MemberShip/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
