using System.Collections.Generic;
using CarDealer.Services.Models.Logs;

namespace CarDealer.Services
{
    public interface ILogService
    {
        void Create(string user, string operation, string tableName);


        IEnumerable<LogModel> All();

        IEnumerable<LogModel> All(string user);

        void Delete();
    }
}
