namespace CarDealer.Web.Controllers
{
    using Services;
    using Services.Models;
    using Models.Customers;
    using Infrastructure.Extensions;
    using Microsoft.AspNetCore.Mvc;

    [Route("customers")]
    public class CustomersController : Controller
    {
        private readonly ICustomerService customers;

        public CustomersController(ICustomerService customers)
        {
            this.customers = customers;
        }

        [Route("all/{order}")]
        public IActionResult All(string order)
        {
            var orderDirection = order.ToLower() == "descending" ? OrderDirection.Descending : OrderDirection.Ascending;

            var result = this.customers.Ordered(orderDirection);

            return this.View(new AllCustomersModel
            {
                Customers = result,
                OrderDirection = orderDirection

            });
        }

        [Route("{id}")]
        public IActionResult TotalSales(int id)
        =>this.ViewOrNotFound(this.customers.TotalSalesById(id));
            
        

    }
}
