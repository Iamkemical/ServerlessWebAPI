using System.Collections.Generic;
using DemoAPI.Models;

namespace DemoAPI.Database
{
    public class StudentDatabase
    {
       public List<Student> DataContext {get; } = new List<Student>()
       {
           new Student() { Id = 1, Name = "Gabriel Isaac"},
           new Student() {Id = 2, Name = "John Doe"},
           new Student() {Id = 3, Name = "Jane Doe"},
           new Student() {Id = 4, Name = "Monday Matsumu"},
           new Student() { Id = 5, Name = "Jerry Corey"}
       };
    }
}