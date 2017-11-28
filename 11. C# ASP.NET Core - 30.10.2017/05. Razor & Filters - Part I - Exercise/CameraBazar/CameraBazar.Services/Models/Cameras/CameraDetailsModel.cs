using CameraBazar.Data.Models;

namespace CameraBazar.Services.Models.Cameras
{
   public class CameraDetailsModel : CameraModel
    {
        public int MinShutterSpeed { get; set; }

        public int MaxShutterSpeed { get; set; }

        public MinISOType MinISO { get; set; }

        public int MaxISO { get; set; }

        public bool IsFullFrame { get; set; }

        public string VideoResolution { get; set; }

        public LightMeteringType LightMetering { get; set; }

        public string Description { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }
    }
}
