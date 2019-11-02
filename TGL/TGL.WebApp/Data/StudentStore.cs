using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL.WebApp.Models;

namespace TGL.WebApp.Data
{
    public class StudentStore
    {
        //private List<Student> Students { get; set; } = new List<Student>();

        public TGLContext Context { get; set; }
        public StudentStore(TGLContext context)
        {
            Context = context;
            //Students.Add(new Student
            //{
            //    Age = 17,
            //    Name = "Juan",
            //    LastName = "Perez",
            //    Nit = "123456789"
            //});
            //Students.Add(new Student
            //{
            //    Age = 27,
            //    Name = "Felipe",
            //    LastName = "Orozco",
            //    Nit = "987654321"
            //});
            //Students.Add(new Student
            //{
            //    Age = 14,
            //    Name = "Mateo",
            //    LastName = "Lotero",
            //    Nit = "147852369"
            //});
        }

        internal void EditStudent(Student student)
        {
            //var currentStudent = GetStudentById(student.Id);
            Student currentStudent = GetStudentById(student.Id);
            currentStudent.Name = student.Name;
            currentStudent.LastName = student.LastName;
            currentStudent.Nit = student.Nit;
            currentStudent.Age = student.Age;
            Context.Student.Update(currentStudent);
            Context.SaveChanges();

        }

        internal Student GetStudentById(Guid id)
        {
            return Context.Student.FirstOrDefault(x => x.Id == id);
            //return Students.FirstOrDefault(x => x.Id == id);
        }

        internal void AddStudent(Student student)
        {
            Context.Student.Add(student);
            Context.SaveChanges();
            //Students.Add(student);
        }

        internal void DeleteStudent(Guid id)
        {
            var student = Context.Student.FirstOrDefault(x => x.Id == id);
            Context.Student.Remove(student);
            Context.SaveChanges();
            //var student = Students.FirstOrDefault(x => x.Id == id);
            //Students.Remove(student);
        }

        public List<Student> GetStudents() {
            return Context.Student.Include(x => x.Computers).ToList();
            //return this.Students;
        }
    }
}
