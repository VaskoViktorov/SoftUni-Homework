namespace CarDealer.Services.Implementations
{
    using System.Collections.Generic;
    using Models.Sales;
    using System.Linq;
    using Data;
    using Models.Cars;

    public class SaleService : ISaleService
    {
        private readonly CarDealerDbContext db;

        public SaleService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<SaleListModel> All()
            => this.db
                .Sales
                .Select(s => new SaleListModel
                {
                    Id = s.Id,
                    CustomerName = s.Customer.Name,
                    Price = s.Car.Parts.Sum(c => c.Part.Price),
                    IsYoungDriver = s.Customer.IsYoungDriver,
                    Discount = s.Discount
                })
                .ToList();

        public SaleDetailsModel Details(int id)
            => this.db
                .Sales
                .Where(s => s.Id == id)
                .Select(s => new SaleDetailsModel
                {
                    Id = s.Id,
                    CustomerName = s.Customer.Name,
                    Price = s.Car.Parts.Sum(c => c.Part.Price),
                    IsYoungDriver = s.Customer.IsYoungDriver,
                    Discount = s.Discount,
                    Car = new CarModel
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TravelledDistance = s.Car.TravelledDistance
                    }
                })
                .FirstOrDefault();

        public IEnumerable<SaleListModel> Discounted()
            => this.db
                .Sales
                .Where(s => s.Discount > 0)
                .Select(s => new SaleListModel
                {
                    Id = s.Id,
                    CustomerName = s.Customer.Name,
                    Price = s.Car.Parts.Sum(c => c.Part.Price),
                    IsYoungDriver = s.Customer.IsYoungDriver,
                    Discount = s.Discount
                })
                .ToList();

        public IEnumerable<SaleListModel> DiscountedPercent(double percent)
            => this.db
                .Sales
                .Where(s => ((s.Discount + (s.Customer.IsYoungDriver ? 0.05 : 0)) * 100).ToString("F2") == percent.ToString("F2"))
                .Select(s => new SaleListModel
                {
                    Id = s.Id,
                    CustomerName = s.Customer.Name,
                    Price = s.Car.Parts.Sum(c => c.Part.Price),
                    IsYoungDriver = s.Customer.IsYoungDriver,
                    Discount = s.Discount
                })
                .ToList();
    }
}
