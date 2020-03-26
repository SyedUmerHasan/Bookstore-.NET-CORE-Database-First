using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore_.NET_Core_Database_First.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookStore_.NET_Core_Database_First.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            using (var ctx = new CRUD_DATABASEFIRSTContext())
            {
                Student student; 
                student = ctx.Student.Where(s => s.Name == "Umer Hasan").FirstOrDefault();
                if(student == null)
                {
                    student = new Student();
                    student.Name = "syed umer haasn";
                    ctx.Student.Add(student);
                }

                ctx.SaveChanges();

                return ctx.Student.Where(obj => obj.Name == "syed umer haasn").ToList();
            }
        }
        //public string Get()
        //{
        //    return "umer";
        //}



    }
}
