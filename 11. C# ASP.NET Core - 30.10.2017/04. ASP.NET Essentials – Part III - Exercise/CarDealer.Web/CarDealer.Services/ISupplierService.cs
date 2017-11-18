namespace CarDealer.Services
{
    using System.Collections.Generic;
    using Models.Suppliers;

    public interface ISupplierService
    {
        IEnumerable<SuppliersListingModel> AllListings(bool isImporter);

        IEnumerable<SupplierModel> All();

        void Create(string modelName, bool modelIsImporter);

       SupplierBasicModel ById(int id);

        void Edit(int id, string modelName, bool modelIsImproter);

        bool Exists(int id);

        void Delete(int id);
    }
}
