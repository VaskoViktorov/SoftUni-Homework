using CarDealer.Data.Models;

namespace CarDealer.Services.Implementations
{
    using System.Collections.Generic;
    using System.Linq;
    using Data;
    using Models.Cars;
    using Models.Parts;

    public class CarService : ICarService
    {
        private readonly CarDealerDbContext db;

        public CarService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<CarModel> ByMake(string make)
        => this.db
                .Cars
                .Where(c => c.Make.ToLower() == make.ToLower())
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TravelledDistance)
                .Select(c => new CarModel
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance
                })
                .ToList();

        public IEnumerable<CarWithPartsModel> WithParts()
            => this.db
                .Cars
                .OrderByDescending(c => c.Id)
                .Select(c => new CarWithPartsModel
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance,
                    Parts = c.Parts.Select(p => new PartModel
                    {
                        Name = p.Part.Name,
                        Price = p.Part.Price
                    })

                })
                .ToList();

        public IEnumerable<CarWithPartsModel> Details(int id)
            => this.db
                .Cars
                .Where(s => s.Id == id)
                .Select(c => new CarWithPartsModel
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance,
                    Parts = c.Parts.Select(p => new PartModel
                    {
                        Name = p.Part.Name,
                        Price = p.Part.Price
                    })

                })
                .ToList();

        public void Create(string modelMake, string modelModel, long modelTravelledDistance, IEnumerable<int> modelAllParts)
        {
            var existingPartIds = this.db
                .Parts
                .Where(p => modelAllParts.Contains(p.Id))
                .Select(p => p.Id)
                .ToList();

            var car = new Car
            {
                Make = modelMake,
                Model = modelModel,
                TravelledDistance = modelTravelledDistance,
            };

            foreach (var partId in existingPartIds)
            {
                car.Parts.Add(new PartCar
                {
                    PartId = partId
                });
            }

            this.db.Add(car);
            this.db.SaveChanges();


        }

        public IEnumerable<BasicCarModel> AllCars()
            => this.db
                .Cars
                .OrderByDescending(s => s.Id)
                .Select(s => new BasicCarModel()
                {
                    Id = s.Id,
                    Model = s.Make + " " + s.Model
                })
                .ToList();

        public PriceModel ById(int id)
            => this.db
                .Cars
                .Where(s => s.Id == id)
                .Select(s => new PriceModel()
                {
                    Id = s.Id,
                    Price = s.Parts.Sum(p => p.Part.Price),
                    MakeModel = s.Make + " " + s.Model
                })
                .FirstOrDefault();
    }
}
