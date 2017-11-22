using System.Collections;
using System.Collections.Generic;
using CameraBazar.Services.Models.Cameras;

namespace CameraBazar.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using Data.Models;
    using Services;
    using Models.Cameras;
    using Microsoft.AspNetCore.Identity;

    public class CamerasController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly ICameraService cameras;

        public CamerasController(UserManager<User> userManager, ICameraService cameras)
        {
            this.cameras = cameras;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult Add() => this.View();

        [Authorize]
        [HttpPost]
        public IActionResult Add(AddCameraViewModel cameraModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(cameraModel);
            }

            this.cameras.Create(
                cameraModel.Make,
                cameraModel.Model,
                cameraModel.Price,
                cameraModel.Quantity,
                cameraModel.MinShutterSpeed,
                cameraModel.MaxShutterSpeed,
                cameraModel.MinISO,
                cameraModel.MaxISO,
                cameraModel.IsFullFrame,
                cameraModel.VideoResolution,
                cameraModel.LightMetering,
                cameraModel.Description,
                cameraModel.ImageUrl,
                this.userManager.GetUserId(this.User));

            return this.RedirectToAction(nameof(HomeController.Index),"Home");
        }

        public IActionResult All()
            => this.View(this.cameras.All());

        [Authorize]
        public IActionResult Edit(int id)
        {
            var camera = this.cameras.ById(id);

            if (camera == null)
            {
                return this.NotFound();
            }

            return this.View(new AddCameraViewModel()
            {               
                Make = camera.Make,
                Model = camera.Model,
                Price = camera.Price,
                Quantity = camera.Quantity,
                MinShutterSpeed = camera.MinShutterSpeed,
                MaxShutterSpeed = camera.MaxShutterSpeed,
                MinISO = camera.MinISO,
                MaxISO = camera.MaxISO,
                LightMetering = new List<LightMeteringType>{LightMeteringType.CenterWeighted},
                IsFullFrame = camera.IsFullFrame,
                VideoResolution = camera.VideoResolution,
                Description = camera.Description,
                ImageUrl = camera.ImageUrl
            });
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(int id, AddCameraViewModel cameraModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(cameraModel);
            }

            this.cameras.Edit(
                id,
                cameraModel.Make,
                cameraModel.Model,
                cameraModel.Price,
                cameraModel.Quantity,
                cameraModel.MinShutterSpeed,
                cameraModel.MaxShutterSpeed,
                cameraModel.MinISO,
                cameraModel.MaxISO,
                cameraModel.IsFullFrame,
                cameraModel.VideoResolution,
                cameraModel.LightMetering,
                cameraModel.Description,
                cameraModel.ImageUrl);

            return this.RedirectToAction(nameof(this.All));
        }

        [Authorize]
        public IActionResult Delete(int id)
            => this.View(id);

        [Authorize]
        public IActionResult Destroy(int id)
        {
            this.cameras.Delete(id);         

            return this.RedirectToAction(nameof(this.All));
        }

        public IActionResult Details(int id)
            => this.View(this.cameras.ById(id));
    }
}
