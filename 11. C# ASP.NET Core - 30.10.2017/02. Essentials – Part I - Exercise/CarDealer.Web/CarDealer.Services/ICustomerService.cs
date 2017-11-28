namespace CarDealer.Services
{
    using System.Collections.Generic;
    using Models.Customers;
    using Models;

    public interface ICustomerService
    {
        IEnumerable<CustomerModel> Ordered(OrderDirection order);

        CustomerTotalSalesModel TotalSalesById(int id);
    }
}
