using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StudentsAPI.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StudentsAPI.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly string DATABASE_PATH = @"Data\studenci.json";
        private static List<Student> _students = new List<Student>();
        public StudentsController()
        {
            using (StreamReader sr = new StreamReader(@"Data\studenci.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                _students = (List<Student>)serializer.Deserialize(sr, typeof(List<Student>));
            }
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_students);
        }


        [HttpPost]
        public IActionResult CreateStudent([FromBody] Student student)
        {
            
            if (Walidacja(student))
            {
                _students.Add(student);
                SaveStudents();
                return StatusCode(201, student); //Created
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("{studentId}")]
        public IActionResult GetStudent(int studentId)
        {
            Student s = _students.FirstOrDefault(x => x.StudentId == studentId);
            if(s != null)
            {
                return Ok(s);
            } else
            {
                return NotFound("Osoba nie istnieje");
            }
        }     
     
        [HttpDelete("{studentId}")]
        public IActionResult DeleteStudent([FromRoute] int studentId)
        {
            var s = _students.FirstOrDefault(x => x.StudentId == studentId);
            if (s == null)
            {
                return NotFound("Osoba o podanym numerze ID nie istnieje w bazie.");
            } else
            {
                _students.Remove(s);
                SaveStudents();
                return NoContent();
            }
        }

        [HttpPatch("{studentId}")]
        public IActionResult UpdateStudent([FromBody] Student student, [FromRoute] int studentId)
        {
            var s = _students.FirstOrDefault(x => x.StudentId == studentId);
            if (s == null)
            {
                return NotFound("Osoba nie istnieje");
            }
            else
            {
                int idx = _students.IndexOf(s);
                _students[idx] = student;
                SaveStudents();
                return Ok(s);
            }
        }
        private bool Walidacja(Student s)
        {
            string msg = "";
            if (string.IsNullOrEmpty(s.FirstName) || string.IsNullOrEmpty(s.LastName) || string.IsNullOrEmpty(s.IndexNumber))
            {
                msg = "za malo danych";
                UnprocessableEntity(msg);
                return false;
            }

            if (!s.Email.Contains('@') || !s.Email.Contains('.'))
            {
                msg = "zly email, uzyj @ i kropki";
                UnprocessableEntity(msg);
                return false;
            }

            if (_students.FirstOrDefault(x => x.StudentId == s.StudentId) != null)
            {
                msg = "Student z takim ID juz istnieje";
                UnprocessableEntity(msg);
                return false;
            }

            return true;
        }

        private void SaveStudents()
        {
            using (StreamWriter file = System.IO.File.CreateText(DATABASE_PATH))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, _students);
            }
        }
    }
}
