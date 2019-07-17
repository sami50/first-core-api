using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace first_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        // GET: api/Todo
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Todo/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Todo
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Todo/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("test")]
        public string test()
        {
            return "sami";
        }
        [HttpGet("ll")]
        public int test2()
        {
            return 4154;
        }

        [HttpGet("Search")]
        public IActionResult Search(string namelike)
        {
            var result = (namelike);
           
            return Ok(result);
        }
        [HttpGet("sm")]
        public List<dynamic> getList()
        {
            var list = new List<dynamic>();
            dynamic DyObj = new ExpandoObject();
            DyObj.studentName = "samithra Niroshana";
            DyObj.studentAge = 20;

            list.Add(DyObj);

            dynamic DyObj2 = new ExpandoObject();
            DyObj2.studentName = "Akalanka Udara";
            DyObj2.studentAge = 30;

            list.Add(DyObj2);



            return list;

        }

    }
}
