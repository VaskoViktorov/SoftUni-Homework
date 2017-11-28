namespace CameraBazar.Services.Models.Cameras
{
    using Data.Models;

    public class CameraModel
    {
        public int Id { get; set; }

        public CameraMakeType Make { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
     
        public string ImageUrl { get; set; }
    }
}
