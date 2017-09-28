namespace _02._Social.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Tag
    {
        public int Id { get; set; }

        [Required]
        [Tag]
        [MaxLength(20)]
        public string Content { get; set; }

        public List<TagAlbum> Albums { get; set; } = new List<TagAlbum>();
    }
}
