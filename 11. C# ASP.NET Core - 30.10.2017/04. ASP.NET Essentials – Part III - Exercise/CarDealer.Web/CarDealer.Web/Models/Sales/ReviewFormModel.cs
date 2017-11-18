using System.ComponentModel.DataAnnotations;

namespace CarDealer.Web.Models.Sales
{
    public class ReviewFormModel
    {
        public int CustomerId { get; set; }

        [Display(Name = "Customer")]
        public string CustomerName { get; set; }

        public bool IsYoungDriver { get; set; }

        public int CarId { get; set; }

        [Display(Name = "Car")]
        public string CarName { get; set; }

        public double Discount { get; set; }

        [Display(Name = "Car Price")]
        public decimal CarPrice { get; set; }

        [Display(Name = "Final Car Price")]
        public decimal FinalCarPrice
            => this.CarPrice - (this.CarPrice * ((decimal)this.Discount));
    }
}
