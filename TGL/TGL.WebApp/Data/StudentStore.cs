using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL.WebApp.Models;

namespace TGL.WebApp.Data
{
    public class StudentStore
    {
        private List<Student> Students { get; set; } = new List<Student>();

        public StudentStore()
        {
            Students.Add(new Student
            {
                Age = 17,
                Name = "Juan",
                LastName = "Perez",
                Nit = "123456789"
            });
            Students.Add(new Student
            {
                Age = 27,
                Name = "Felipe",
                LastName = "Orozco",
                Nit = "987654321"
            });
            Students.Add(new Student
            {
                Age = 14,
                Name = "Mateo",
                LastName = "Lotero",
                Nit = "147852369"
            });
        }

        internal void AddStudent(Student student)
        {
            Students.Add(student);
        }

        internal void DeleteStudent(Guid id)
        {
            var student = Students.FirstOrDefault(x => x.Id == id);
            Students.Remove(student);
        }

        public List<Student> GetStudents() {
            return this.Students;
        }
    }
}
