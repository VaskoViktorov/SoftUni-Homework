namespace CarDealer.Services
{
    using System.Collections.Generic;
    using Models.Cars;

    public interface ICarService
    {
        IEnumerable<CarModel> ByMake(string make);

        IEnumerable<CarWithPartsModel> WithParts();

        IEnumerable<CarWithPartsModel> Details(int id);

        void Create(string modelMake, string modelModel, long modelTravelledDistance, IEnumerable<int> modelAllParts);

    }
}
