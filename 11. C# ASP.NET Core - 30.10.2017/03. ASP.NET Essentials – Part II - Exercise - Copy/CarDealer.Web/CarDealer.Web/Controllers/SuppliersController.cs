using CarDealer.Services;
using CarDealer.Web.Models.Suppliers;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Web.Controllers
{
    public class SuppliersController : Controller
    {
        private const string SuppliersView = "Suppliers";

        private readonly ISupplierService suppliers;

        public SuppliersController(ISupplierService supliers)
        {
            this.suppliers = supliers;
        }

        public IActionResult Local()
        => View(SuppliersView, this.GetSupplierModel(false));

        
        public IActionResult Importers()
        =>View(SuppliersView, this.GetSupplierModel(true));

        private SupplierListingModel GetSupplierModel(bool importers)
        {
            var type = importers ? "Importer" : "Local";

            var suppliers = this.suppliers.AllListings(importers);

            return   new SupplierListingModel
            {
                Type = type,
                Suppliers = suppliers
            };
        }
    }
}
