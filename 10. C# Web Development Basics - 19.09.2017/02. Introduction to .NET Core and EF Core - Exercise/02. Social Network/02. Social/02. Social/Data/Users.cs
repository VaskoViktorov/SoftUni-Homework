namespace _02._Social.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Users
    {
        public int Id { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(50)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,50}$")]
        public string Password { get; set; }

        [Required]
        [RegularExpression(@"^[^\.\-_]([\w\.\-]+)[^\.\-_]@([\w\-\.]+)\.([\.\w])+$")]
        public string Email { get; set; }
        
        public byte[] ProfilePic { get; set; }

        public DateTime RegistratedOn { get; set; }

        public DateTime LastTimeLoggedIn { get; set; }

        [Range(1,120)]
        public int? Age { get; set; }

        public bool IsDeleted { get; set; }

        public List<UserFriend> FriendsOfMine { get; set; } = new List<UserFriend>();

        public List<UserFriend> FriendsToMe { get; set; } = new List<UserFriend>();

        public List<Album> Albums { get; set; } = new List<Album>();

        public List<UserAlbum> UserAlbums { get; set; } = new List<UserAlbum>();
    }
}
