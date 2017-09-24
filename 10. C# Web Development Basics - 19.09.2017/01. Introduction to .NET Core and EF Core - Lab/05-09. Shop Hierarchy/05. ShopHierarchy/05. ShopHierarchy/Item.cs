using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _05._ShopHierarchy
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public ICollection<Review> Reviews { get; set; } = new List<Review>();

        public List<ItemOrder> Orders { get; set; } = new List<ItemOrder>();
    }
}
