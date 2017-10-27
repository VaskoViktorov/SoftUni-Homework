using System;
using App.GameStore.Infrastructure.Validation;
using App.GameStore.Infrastructure.Validation.Games;
using SimpleMvc.Framework.Attributes.Validation;


namespace App.GameStore.Models.Games
{
    public class GameAdminModel
    {
        [Required]
        [Title]
        public string Title { get; set; }

        [Required]
        [Description]
        public string Description { get; set; }

        [ThumbnailUrl]
        public string Thumbnail { get; set; }

        [NumberRange(0,double.MaxValue)]
        public decimal Price { get; set; }

        [NumberRange(0, double.MaxValue)]
        public  double Size { get; set; }

        [Required]
        [VideoId]
        public string VideoId { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
