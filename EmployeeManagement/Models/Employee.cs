using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage ="Name cannot exceed 50 characters")]
        public String Name { get; set; }
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email Format")]
        [Display(Name="Office Email")]
        public String Email { get; set; }
        public  Dept? Department { get; set; }
        public string PhotoPath { get; set; }

    }
}
