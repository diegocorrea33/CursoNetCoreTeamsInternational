using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TGL.WebApp.Models
{
    public class Student
    {
        public Student()
        {
            Id = Guid.NewGuid();
        }
        
        public int? Age { get; set; }
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Nit { get; set; }
        
        
        public Guid Id { get; set; } 
        

        //public Guid Id { get; set; } = Guid.NewGuid();

    }
}
