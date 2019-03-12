using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VidzMatheus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET http://localhost:5000/api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
        var sArray = new string[] { "Matheus", "Gabriel", "Santos" };
        return sArray;
        }

        // GET http://localhost:5000/api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var sArray = new string[] {"Matheus", "Gabriel"};
           if (id > (sArray.Length - 1))
            return "O valor digitado é maior do que o disponível";

            return sArray[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
