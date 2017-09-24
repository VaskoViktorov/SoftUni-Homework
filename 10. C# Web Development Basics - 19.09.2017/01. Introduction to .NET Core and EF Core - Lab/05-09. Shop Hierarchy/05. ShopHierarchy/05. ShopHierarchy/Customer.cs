using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _05._ShopHierarchy
{
   public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int SalesmenId { get; set; }

        public Salesmen Salesmen { get; set; }

        public ICollection<Order> Orders {get; set; } = new List<Order>();

        public ICollection<Review> Reviews { get; set; } = new List<Review>();

    }
}
