using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClassroomController : ControllerBase
    {
        public static List<Product> Student = new List<Product>
        {
            new Product{
                Id = Guid.NewGuid().ToString(),
                ProductName ="นายแดง",
                  Price = 5,
                 Pieces = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSAuYMJ0yTQq3XoYeHjrYstcCJnxKJEtlWnWP8aQviBS_lXnF64"
            },
            new Product{
                Id = Guid.NewGuid().ToString(),
                ProductName ="นายดำ",
                  Price = 6,
                 Pieces = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrocWot2tcvZduZ13z6KrxJ2YnT-66jHgphq0egIrWAb2Ap-Sm"
            },
            new Product{
                Id = Guid.NewGuid().ToString(),
                ProductName ="นายเขียว",
                  Price = 7,
                 Pieces = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTUsoakftmf6A5PVKLwpeG-yfLmlXgdMzQeJw-N4dxi0UmYt4bB"
            },

        };
        [HttpGet]
        public List<Product> GetAllStudents(){
            return Student;

        }
         [HttpGet("{id}")]
        public Product GetStudents(string id){
            return Student.Find(it=>it.Id==id);

        }
        [HttpPost]
        public  void CreateStudent([FromBody]Product newStudent) {
            newStudent.Id = Guid.NewGuid().ToString();
            Student.Add(newStudent);
        }
          [HttpPut]
        public  void UpdateStudent([FromBody]Product newStudent) {
           
            var oldStudent= Student.Find(it=>it.Id==newStudent.Id);
            Student.Remove(oldStudent);
            Student.Add(newStudent);
        }
        [HttpDelete("{id}")]
        public  void DeleteStudent(string id) {
           
            var student =Student.Find(it=>it.Id==id);
            Student.Remove(student);
        }
     }
}
