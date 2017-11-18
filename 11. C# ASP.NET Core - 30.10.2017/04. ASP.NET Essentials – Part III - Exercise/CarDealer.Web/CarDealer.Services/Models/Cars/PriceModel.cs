using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Services.Models.Cars
{
    public class PriceModel
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public string MakeModel { get; set; }
    }
}
