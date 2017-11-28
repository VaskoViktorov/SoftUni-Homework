namespace CarDealer.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Log
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Operation { get; set; }

        [Required]
        public string TableName { get; set; }

        public DateTime DateTime { get; set; }
    }
}
