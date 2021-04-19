using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoAPI.Models;
using DemoAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentRepository student;

        public StudentController(StudentRepository student)
        {
            this.student = student;
        }

        // GET api/student
        [HttpGet]
        public IEnumerable<Student> GetAllStudent() => 
            student.GetAllStudent();

        // GET api/student/id
        [HttpGet("{id}")]
        public Student GetStudentById(int id) =>
            student.GetStudentById(id);

        // POST api/student
        [HttpPost]
        public void CreateStudent(Student model) =>
            student.CreateStudent(model);

        // PUT api/student/
        [HttpPut("{id}")]
        public void UpdateStudent(int id, Student model) => 
            student.UpdateStudent(id, model);

        // DELETE api/student/5
        [HttpDelete("{id}")]
        public void DeleteStudent(int id) =>
            student.DeleteStudent(id);
    }
}
