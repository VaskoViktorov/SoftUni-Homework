namespace CarDealer.Services.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Data;
    using Data.Models;
    using Models.Logs;

    public class LogService : ILogService
    {
        private readonly CarDealerDbContext db;

        public LogService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public void Create(string user, string operation, string tableName)
        {
            var log = new Log
            {
                Username = user,
                Operation = operation,
                TableName = tableName,
                DateTime = DateTime.Now
            };

            this.db.Logs.Add(log);
            this.db.SaveChanges();
        }

        public IEnumerable<LogModel> All()
            => this.db
                .Logs
                .OrderBy(l => l.DateTime)
                .Select(c => new LogModel
                {
                   Username = c.Username,
                   Operation = c.Operation,
                   TableName = c.TableName,
                   DateTime = c.DateTime
                })
                .ToList();

        public IEnumerable<LogModel> All(string user)
            => this.db
                .Logs
                .OrderBy(l => l.DateTime)
                .Where(l => l.Username==user)
                .Select(c => new LogModel
                {
                    Username = c.Username,
                    Operation = c.Operation,
                    TableName = c.TableName,
                    DateTime = c.DateTime
                })
                .ToList();

        public void Delete()
        {
            this.db.Logs.RemoveRange(this.db.Logs);
            this.db.SaveChanges();
        }
    }
}
