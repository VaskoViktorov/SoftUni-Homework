using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace CarDealer.Web.Models.Sales
{
    public class SaleFormModel
    {
        public IEnumerable<SelectListItem> AllCars { get; set; }

        [Display(Name = "Car")]
        public int CarId { get; set; }

        public IEnumerable<SelectListItem> AllCustomers { get; set; }

        [Display(Name = "Customer")]
        public int CustomerId { get; set; }

        [Range(0,95)]
        public double Discount { get; set; }
    }
}
