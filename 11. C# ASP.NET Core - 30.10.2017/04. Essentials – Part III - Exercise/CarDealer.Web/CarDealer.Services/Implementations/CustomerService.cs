namespace CarDealer.Services.Implementations
{
    using Models.Customers;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Data;
    using Models.Sales;
    using Data.Models;

    public class CustomerService : ICustomerService
    {
        private readonly CarDealerDbContext db;

        public CustomerService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<CustomerModel> Ordered(OrderDirection order)
        {
            var customersQuerry = this.db.Customers.AsQueryable();

            switch (order)
            {
                case OrderDirection.Ascending:
                    customersQuerry = customersQuerry
                        .OrderBy(c => c.BirthDay)
                        .ThenBy(c => c.Name);

                    break;
                case OrderDirection.Descending:
                    customersQuerry = customersQuerry
                        .OrderByDescending(c => c.BirthDay)
                        .ThenBy(c => c.Name);

                    break;
                default:
                    throw new InvalidOperationException($"Invalid order direction: {order}");
            }

            return customersQuerry
                .Select(c => new CustomerModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    BirthDay = c.BirthDay,
                    IsYoungDriver = c.IsYoungDriver
                })
                .ToList();
        }

        public CustomerTotalSalesModel TotalSalesById(int id)
            => this.db
                .Customers
                .Where(c => c.Id == id)
                .Select(c => new CustomerTotalSalesModel
                {
                    Name = c.Name,
                    IsYoungDriver = c.IsYoungDriver,
                    BoughtCars = c.Sales.Select(s => new SaleModel
                    {
                        Price = s.Car.Parts.Sum(p => p.Part.Price),
                        Discount = s.Discount
                    })
                })
                .FirstOrDefault();

        public void Create(string name, DateTime birthDay, bool isYoungDriver)
        {
            var customer = new Customer
            {
                Name = name,
                BirthDay = birthDay,
                IsYoungDriver = isYoungDriver
            };

            this.db.Add(customer);
            this.db.SaveChanges();
        }

        public CustomerModel ById(int id)
            => this.db
                .Customers
                .Where(c => c.Id == id)
                .Select(c => new CustomerModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    BirthDay = c.BirthDay,
                    IsYoungDriver = c.IsYoungDriver
                })
                .FirstOrDefault();

        public void Edit(int id, string modelName, DateTime modelBirthDay, bool modelIsYoungDriver)
        {
            var existingCustomer = this.db.Customers.Find(id);

            if (existingCustomer == null)
            {
                return;
            }

            existingCustomer.Name = modelName;
            existingCustomer.BirthDay = modelBirthDay;
            existingCustomer.IsYoungDriver = modelIsYoungDriver;

            this.db.SaveChanges();
        }

        public bool Exists(int id)
            => this.db.Customers.Any(c => c.Id == id);

        public void Delete(int id)
        {
            var customer = this.db.Customers.Find(id);

            if (customer == null)
            {
                return;
            }

            this.db.Customers.Remove(customer);
            this.db.SaveChanges();
        }


        public IEnumerable<CustomerModel> AllCustomers()
            => this.db
                .Customers
                .OrderByDescending(s => s.Id)
                .Select(s => new CustomerModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                    IsYoungDriver = s.IsYoungDriver
                })
                .ToList();
    }
}
