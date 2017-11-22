using System.Linq;
using CameraBazar.Services.Models.Cameras;

namespace CameraBazar.Services.Implementations
{
    using System.Collections.Generic;
    using Data;
    using Data.Models;

    class CameraService : ICameraService
    {
        public readonly CameraBazarDbContext db;

        public CameraService(CameraBazarDbContext db)
        {
            this.db = db;
        }

        public void Create(
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
            string userId)
        {
            var camera = new Camera
            {
               Make = make,
               Model = model,
               Price = price,
               Quantity = quantity,
               MinShutterSpeed = minShutterSpeed,
               MaxShutterSpeed = maxShutterSpeed,
               MinISO = minISO,
               MaxISO = maxISO,
               IsFullFrame = isFullFrame,
               VideoResolution = videoResolution,
               LightMetering = (LightMeteringType)lightMetering.Cast<int>().Sum(),
               Description = description,
               ImageUrl = imageUrl,
               UserId = userId
            };

            this.db.Add(camera);

            this.db.SaveChanges();
        }

        public IEnumerable<CameraModel> All()
            => this.db
                .Cameras
                .OrderByDescending(c => c.Id)
                .Select(c => new CameraModel
                {
                   Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    Price = c.Price,
                    Quantity = c.Quantity,
                    ImageUrl = c.ImageUrl
                })
                .ToList();

        public CameraDetailsModel ById(int id)
        => this.db
            .Cameras
            .Where(c => c.Id == id)
            .Select(c => new CameraDetailsModel
            {
                Id = c.Id,
                Make = c.Make,
                Model = c.Model,
                Price = c.Price,
                Quantity = c.Quantity,
                MinShutterSpeed = c.MinShutterSpeed,
                MaxShutterSpeed = c.MaxShutterSpeed,
                MinISO = c.MinISO,
                MaxISO = c.MaxISO,
                IsFullFrame = c.IsFullFrame,
                VideoResolution = c.VideoResolution,
                LightMetering = c.LightMetering,
                Description = c.Description,
                ImageUrl = c.ImageUrl,
                UserId = c.UserId,
                User = c.User
            })
            .FirstOrDefault();

        public void Edit(int id, CameraMakeType modelMake, string modelModel, decimal modelPrice, int modelQuantity,
            int modelMinShutterSpeed, int modelMaxShutterSpeed, MinISOType modelMinIso, int modelMaxIso, bool modelIsFullFrame,
            string modelVideoResolution, IEnumerable<LightMeteringType> modellightMetering, string modelDescription, string modelImageUrl)
        {
            var camera = this.db.Cameras.Find(id);

            if (camera == null)
            {
                return;
            }

            camera.Make = modelMake;
            camera.Model = modelModel;
            camera.Price = modelPrice;
            camera.Quantity = modelQuantity;
            camera.MinShutterSpeed = modelMinShutterSpeed;
            camera.MaxShutterSpeed = modelMaxShutterSpeed;
            camera.MinISO = modelMinIso;
            camera.MaxISO = modelMaxIso;
            camera.IsFullFrame = modelIsFullFrame;
            camera.VideoResolution = modelVideoResolution;
            camera.Description = modelDescription;
            camera.LightMetering = (LightMeteringType)modellightMetering.Cast<int>().Sum();
            camera.ImageUrl = modelImageUrl;
           
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            var part = this.db.Cameras.Find(id);

            if (part == null)
            {
                return;
            }

            this.db.Cameras.Remove(part);
            this.db.SaveChanges();
        }

    }
}
