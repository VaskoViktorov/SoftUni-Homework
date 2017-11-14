namespace CarDealer.Services.Models.Logs
{
    using System;

    public class LogModel
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Operation { get; set; }

        public string TableName { get; set; }

        public DateTime DateTime { get; set; }
    }
}
