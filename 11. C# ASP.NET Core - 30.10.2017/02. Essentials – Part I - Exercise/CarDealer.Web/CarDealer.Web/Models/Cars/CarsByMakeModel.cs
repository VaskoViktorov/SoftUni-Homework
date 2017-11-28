namespace CarDealer.Web.Models.Cars
{
    using System.Collections.Generic;
    using Services.Models.Cars;


    public class CarsByMakeModel
    {
        public IEnumerable<CarModel> Cars { get; set; }

        public string Make { get; set; }
    }
}
