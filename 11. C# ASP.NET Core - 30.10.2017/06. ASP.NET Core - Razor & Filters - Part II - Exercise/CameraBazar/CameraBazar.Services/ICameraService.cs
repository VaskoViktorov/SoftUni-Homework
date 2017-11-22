namespace CameraBazar.Services
{
    using System.Collections.Generic;
    using Data.Models;
    using Models.Cameras;

    public interface ICameraService
    {
        void Create(
            CameraMakeType make,
            string model,
            decimal price,
            int quantity,
            int minShutterSpeed,
            int maxShutterSpeed,
            MinISOType minISO,
            int maxISO,
            bool isFullFrame,
            string videoResolution,
            IEnumerable<LightMeteringType> lightMetering,
            string description,
            string imageUrl,
            string userId
            );

        IEnumerable<CameraModel> All();

        CameraDetailsModel ById(int id);

        void Edit(
            int id,
            CameraMakeType modelMake,
            string modelModel,
            decimal modelPrice,
            int modelQuantity,
            int modelMinShutterSpeed,
            int modelMaxShutterSpeed,
            MinISOType modelMinIso,
            int modelMaxIso,
            bool modelIsFullFrame, 
            string modelVideoResolution,
            IEnumerable<LightMeteringType> lightMetering,
            string modelDescription,
            string modelImageUrl
            );

        void Delete(int id);

    }
}
