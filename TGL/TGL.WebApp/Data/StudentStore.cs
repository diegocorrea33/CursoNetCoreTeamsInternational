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
                Id = Guid.NewGuid(),
                Age = 17,
                Name = "Juan",
                LastName = "Perez",
                Nit = "123456789"
            });
            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 27,
                Name = "Felipe",
                LastName = "Orozco",
                Nit = "987654321"
            });
            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 14,
                Name = "Mateo",
                LastName = "Lotero",
                Nit = "147852369"
            });
        }

        public List<Student> GetStudents() {
            return this.Students;
        }
    }
}
