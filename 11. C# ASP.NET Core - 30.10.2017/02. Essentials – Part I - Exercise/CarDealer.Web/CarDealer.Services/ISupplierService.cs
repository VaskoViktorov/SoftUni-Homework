using System.Collections.Generic;
using CarDealer.Services.Models;

namespace CarDealer.Services
{
    public interface ISupplierService
    {
        IEnumerable<SupplierModel> All(bool isImporter);
    }
}
