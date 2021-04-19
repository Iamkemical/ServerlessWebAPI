using System.Linq;
using System.Collections;
using System.Collections.Generic;
using DemoAPI.Database;
using DemoAPI.Models;

namespace DemoAPI.Repository
{
    public class StudentRepository
    {
        private readonly StudentDatabase student;

        public StudentRepository(StudentDatabase student)
        {
            this.student = student;
        }

        public IEnumerable<Student> GetAllStudent()
        {
            return student.DataContext.ToList();
        }
        
        public Student GetStudentById(int id)
        {
            var studentObj = student.DataContext.FirstOrDefault(x => x.Id == id);

            return studentObj;
        }

        public void CreateStudent(Student model)
        {
            Student newStudent = new Student()
            {
                Id = model.Id,
                Name = model.Name
            };

            student.DataContext.Add(newStudent);
        }

        public void UpdateStudent(int id, Student model)
        {
            var existingStudentObj = student.DataContext.FirstOrDefault(x => x.Id == id);

            Student newStudent = new Student()
            {
                Id = model.Id,
                Name = model.Name
            };

            if(existingStudentObj != null)
            {
                student.DataContext.Remove(existingStudentObj);
                student.DataContext.Add(newStudent);
            }
        }

        public void DeleteStudent(int id)
        {
            var existingStudentObj = student.DataContext.FirstOrDefault(x => x.Id == id);

            if(existingStudentObj != null)
            {
                student.DataContext.Remove(existingStudentObj);
            }
        }
    }
}