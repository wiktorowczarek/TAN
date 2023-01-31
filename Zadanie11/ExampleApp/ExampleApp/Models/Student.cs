using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ExampleApp.Models
{
    public partial class Student
    {
        public int IdStudent { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Address { get; set; }
        public int IdStatus { get; set; }

        public virtual Status IdStatusNavigation { get; set; }
    }
}
