using System;

namespace CarDealer.Services
{
    using System.Collections.Generic;
    using Models.Customers;
    using Models;

    public interface ICustomerService
    {
        IEnumerable<CustomerModel> Ordered(OrderDirection order);

        CustomerTotalSalesModel TotalSalesById(int id);

        void Create(string name, DateTime birthday, bool isYoungDriver);

        CustomerModel ById(int id);

        void Edit(int id, string modelName, DateTime modelBirthDay, bool modelIsYoungDriver);

        bool Exists(int id);

        void Delete(int id);

        IEnumerable<CustomerModel> AllCustomers();
    }
}
