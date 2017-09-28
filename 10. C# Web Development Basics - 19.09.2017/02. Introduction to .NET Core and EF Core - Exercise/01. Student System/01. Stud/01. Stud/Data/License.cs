using System.ComponentModel.DataAnnotations;

namespace _01._Stud.Data
{
   public class License
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int ResourceId { get; set; }

        public Resource Resource { get; set; }
    }
}
