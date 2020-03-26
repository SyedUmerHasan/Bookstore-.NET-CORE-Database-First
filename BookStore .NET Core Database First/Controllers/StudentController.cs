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
        private int count = 2;
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            using (var context = new CRUD_DATABASEFIRSTContext())
            {

                Student obj = new Student();
                obj.Name = "Umer hasan";
                obj.Class = "Final Year";
                obj.RollNumber = "k163893";
                
                context.Student.Add(obj);
                context.SaveChanges();

                return context.Student.ToList();
            }
        }

       

    }
}
