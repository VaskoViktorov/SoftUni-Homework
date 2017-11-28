namespace CarDealer.Services
{
    using System.Collections.Generic;
    using Models.Parts;

    public interface IPartService
   {
       IEnumerable<PartListingModel> AllListings(int page = 1, int pageSize = 10);

       IEnumerable<PartBasicModel> All();

       int Total();

       void Create(string modelName, decimal modelPrice, int modelQuantity, int modelSupplierId);

       void Delete(int id);

       PartDetailsModel ById(int id);

       void Edit(int id, decimal modelPrice, int modelQuantity);
   }
}
