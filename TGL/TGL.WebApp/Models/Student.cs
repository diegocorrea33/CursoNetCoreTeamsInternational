using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TGL.WebApp.Models
{
    public class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Nit { get; set; }
        public Guid Id { get; set; }
    }
}
