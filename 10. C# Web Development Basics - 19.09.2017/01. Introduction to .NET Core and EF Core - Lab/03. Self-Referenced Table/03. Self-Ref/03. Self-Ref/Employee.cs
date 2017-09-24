using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _03._Self_Ref
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int DepartmentId { get; set; }

        public int? ManagerId { get; set; }

        public Department Department { get; set; }
      
        public Employee Manager { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
