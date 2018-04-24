using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //Read
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        //Create
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        //Replace
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        //Modify
        [HttpPatch("{id}")]
        public void Patch(int id, [FromBody]string value)
        {
        }

        //Delete
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
