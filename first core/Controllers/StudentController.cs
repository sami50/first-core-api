using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace first_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
       

        [HttpGet]
        public ActionResult<IEnumerable<string>> Test()
        {
            return new string[] { "value1", "value2" };
        }

        
        [HttpPost("save")]
        public ActionResult saveStudent(object ob)
        {

            return Ok(ob);
        }

        [HttpGet("getStudentList")]
        public List<dynamic> getList()
        {
            var list = new List<dynamic>();
            dynamic DyObj = new ExpandoObject();
            DyObj.studentName = "samithra Niroshana";
            DyObj.Age = 20;
            DyObj.Mobile = 5545545;
            DyObj.Member = true;
            list.Add(DyObj);

            dynamic DyObj2 = new ExpandoObject();
            DyObj2.studentName = "Akalanka Udara";
            DyObj2.Age = 30;
            DyObj2.Mobile = 54545;
            DyObj2.Member = false;

            list.Add(DyObj2);

            dynamic DyObj3 = new ExpandoObject();
            DyObj3.studentName = "Yahampath Udara";
            DyObj3.Age = 30;
            DyObj3.Mobile = 54545;
            DyObj3.Member = false;

            list.Add(DyObj3);


            return list;

        }

    }
}