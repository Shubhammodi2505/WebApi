using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
       static List<Student> students = new List<Student>();  // declared static initialization of list for Student object/instance
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get() // For getting the list of students 
        {
            return students ;
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public Student Get(int id) // For getting the Students by id
        {
            return students.FirstOrDefault(x=>x.StudentId == id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] Student value) // For inserting students record 
        {
            students.Add(value);
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student value) // For updating student record by Id
        {
            int i = students.FindIndex(x=>x.StudentId == id);
            if (i >= 0)
                students[i] = value;
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)  // For deleteing student record by Id
        {
            students.RemoveAll(x=>x.StudentId == id);
        }
    }
}
