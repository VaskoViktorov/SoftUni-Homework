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
    }
}
