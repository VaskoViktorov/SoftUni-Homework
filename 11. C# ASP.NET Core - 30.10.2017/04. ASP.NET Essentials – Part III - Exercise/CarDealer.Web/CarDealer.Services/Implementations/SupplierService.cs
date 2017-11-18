using CarDealer.Data.Models;

namespace CarDealer.Services.Implementations
{
    using Models.Suppliers;
    using System.Collections.Generic;
    using System.Linq;
    using Data;

    public class SupplierService :ISupplierService
    {
        private readonly CarDealerDbContext db;

        public SupplierService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<SuppliersListingModel> AllListings(bool isImporter)
            => this.db
                .Suppliers
                .OrderByDescending(s => s.Id)
                .Where(s => s.IsImporter == isImporter)
                .Select(s => new SuppliersListingModel
                {
                    Id = s.Id,
                    Name = s.Name,
                    TotalParts = s.Parts.Count
                })
                .ToList();

        public IEnumerable<SupplierModel> All()
        => this.db
                .Suppliers
                .OrderBy(s => s.Name)                
                .Select(s => new SupplierModel
                {
                    Id = s.Id,
                    Name = s.Name,                    
                })
                .ToList();

        public void Create(string modelName, bool modelIsImporter)
        {
            var supplier = new Supplier
            {
                Name = modelName,
                IsImporter = modelIsImporter
            };

            this.db.Add(supplier);
            this.db.SaveChanges();
        }

        public SupplierBasicModel ById(int id)
            => this.db
                .Suppliers
                .Where(s => s.Id == id)
                .Select(s => new SupplierBasicModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                    IsImporter = s.IsImporter
                })
                .FirstOrDefault();

        public void Edit(int id, string modelName, bool modelIsImporter)
        {
            var existingSupplier = this.db.Suppliers.Find(id);

            if (existingSupplier == null)
            {
                return;
            }

            existingSupplier.Name = modelName;
            existingSupplier.IsImporter = modelIsImporter;


            this.db.SaveChanges();
        }

        public bool Exists(int id)
            => this.db.Suppliers.Any(c => c.Id == id);

        public void Delete(int id)
        {
            var supplier = this.db.Suppliers.Find(id);

            if (supplier == null)
            {
                return;
            }

            this.db.Suppliers.Remove(supplier);
            this.db.SaveChanges();
        }
    }
}
