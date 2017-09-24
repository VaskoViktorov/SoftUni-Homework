using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _05._ShopHierarchy
{
    public class Salesmen
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Customer> Customers { get; set; } = new List<Customer>();
    }
}
