namespace CarDealer.Web.Models.Suppliers
{
    using System.Collections.Generic;
    using Services.Models.Suppliers;

    public class SupplierListingModel
    {
        public string Type { get; set; }

        public IEnumerable<SuppliersListingModel> Suppliers { get; set; }



    }
}
