namespace _02._Social.Data
{
    public class TagAlbum
    {
        public int TagId { get; set; }

        public Tag Tag { get; set; }

        public int AlbumId { get; set; }

        public Album Album { get; set; }
    }
}
