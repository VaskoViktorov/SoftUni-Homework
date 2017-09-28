namespace _02._Social.Data
{
   public class UserAlbum
    {
        public int UserId { get; set; }

        public Users User { get; set; }

        public int AlbumId { get; set; }

        public Album Album { get; set; }

        public UserTypes UserType { get; set; }
    }
}
