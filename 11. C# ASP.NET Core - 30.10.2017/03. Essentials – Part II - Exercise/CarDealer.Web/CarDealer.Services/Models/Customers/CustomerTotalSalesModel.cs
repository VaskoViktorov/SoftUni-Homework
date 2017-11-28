namespace CarDealer.Services.Models.Customers
{
    using System.Collections.Generic;
    using Sales;
    using System.Linq;

    public class CustomerTotalSalesModel
    {
        public string Name { get; set; }

        public bool IsYoungDriver { get; set; }

        public IEnumerable<SaleModel> BoughtCars { get; set; }

        public decimal TotalSpentMoney
            => this.BoughtCars
                   .Sum(c => c.Price * (1m - ((decimal) c.Discount+ (this.IsYoungDriver ? 0.05m : 0m))));
    }   
}
