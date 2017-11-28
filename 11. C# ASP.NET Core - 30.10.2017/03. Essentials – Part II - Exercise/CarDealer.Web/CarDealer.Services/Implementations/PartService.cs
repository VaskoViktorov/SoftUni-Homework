namespace CarDealer.Services.Implementations
{
    using System.Collections.Generic;
    using Models.Parts;
    using System.Linq;
    using Data;
    using Data.Models;

    class PartService : IPartService
    {

        private readonly CarDealerDbContext db;

        public PartService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<PartListingModel> AllListings(int page = 1, int pageSize = 10)
            => this.db
                .Parts
                .OrderByDescending(p => p.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(p => new PartListingModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Quantity = p.Quantity,
                    SupplierName = p.Supplier.Name
                })
                .ToList();

        public IEnumerable<PartBasicModel> All()
            => this.db
                .Parts
                .OrderByDescending(p => p.Id)
                .Select(p => new PartBasicModel
                {
                    Id = p.Id,
                    Name = p.Name
                })
                .ToList();

        public int Total()
            => this.db
                .Parts
                .Count();

        public void Create(string modelName, decimal modelPrice, int modelQuantity, int modelSupplierId)
        {
            var part = new Part
            {
                Name = modelName,
                Price = modelPrice,
                Quantity = modelQuantity > 0 ? modelQuantity : 1,
                SupplierId = modelSupplierId,

            };

            this.db.Parts.Add(part);
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            var part = this.db.Parts.Find(id);

            if (part == null)
            {
                return;
            }

            this.db.Parts.Remove(part);
            this.db.SaveChanges();
        }

        public PartDetailsModel ById(int id)
            => this.db
                .Parts
                .Where(p => p.Id == id)
                .Select(p => new PartDetailsModel
                {
                    Name = p.Name,
                    Price = p.Price,
                    Quantity = p.Quantity
                })
                .FirstOrDefault();

        public void Edit(int id, decimal modelPrice, int modelQuantity)
        {
            var part = this.db.Parts.Find(id);

            if (part == null)
            {
                return;
            }

            part.Price = modelPrice;
            part.Quantity = modelQuantity;

            this.db.SaveChanges();
        }
    }
}
