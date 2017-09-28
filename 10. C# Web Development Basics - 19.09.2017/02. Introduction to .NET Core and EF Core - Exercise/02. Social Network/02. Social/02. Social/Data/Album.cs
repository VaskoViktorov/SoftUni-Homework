namespace _02._Social.Data
{
    using System.Collections.Generic;

    public class Album
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string BackgroundColor { get; set; }

        public string Information { get; set; }

        public bool IsPublic { get; set; }

        public List<PictureAlbum> Pictures { get; set; } = new List<PictureAlbum>();

        public int UserId { get; set; }
       
        public Users User { get; set; }

        public List<TagAlbum> Tags { get; set; } = new List<TagAlbum>();

        public List<UserAlbum> Users { get; set; } = new List<UserAlbum>();
    }
}
