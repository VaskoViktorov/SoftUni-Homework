using System.Collections.Generic;
using CarDealer.Services.Models.Sales;

namespace CarDealer.Services
{
    public interface ISaleService
    {
        IEnumerable<SaleListModel> All();

        SaleDetailsModel Details(int id);

        IEnumerable<SaleListModel> Discounted();

        IEnumerable<SaleListModel> DiscountedPercent(double percent);
    }
}
