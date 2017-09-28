namespace _02._Social.Data
{
    using Microsoft.EntityFrameworkCore;


    class SocialNetworkDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Picture> Pictures { get; set; }

        public DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer($"Server=.;Database=SocialNetworkDb;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<UserFriend>()
                .HasKey(k => new {k.UserId,k.FriendId });


            builder
                .Entity<UserFriend>()
                .HasOne(f => f.User)
                .WithMany(u => u.FriendsOfMine)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Restrict);


            builder
                .Entity<UserFriend>()
                .HasOne(f => f.Friend)
                .WithMany(u => u.FriendsToMe)
                .HasForeignKey(u => u.FriendId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<PictureAlbum>()
                .HasKey(k => new {k.PictureId, k.AlbumId});

            builder
                .Entity<PictureAlbum>()
                .HasOne(a => a.Picture)
                .WithMany(p => p.Albums)
                .HasForeignKey(p => p.PictureId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<PictureAlbum>()
                .HasOne(p => p.Album)
                .WithMany(a => a.Pictures)
                .HasForeignKey(a => a.AlbumId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Users>()
                .HasMany(u => u.Albums)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId);

            builder
                .Entity<TagAlbum>()
                .HasKey(k => new {k.TagId, k.AlbumId});

            builder
                .Entity<TagAlbum>()
                .HasOne(t => t.Album)
                .WithMany(a => a.Tags)
                .HasForeignKey(t => t.AlbumId);

            builder
                .Entity<TagAlbum>()
                .HasOne(a => a.Tag)
                .WithMany(t => t.Albums)
                .HasForeignKey(t => t.TagId);

            builder
                .Entity<UserAlbum>()
                .HasKey(k => new {k.UserId, k.AlbumId});

            builder
                .Entity<UserAlbum>()
                .HasOne(u => u.Album)
                .WithMany(a => a.Users)
                .HasForeignKey(u => u.AlbumId);

            builder
                .Entity<UserAlbum>()
                .HasOne(a => a.User)
                .WithMany(u => u.UserAlbums)
                .HasForeignKey(u => u.UserId);
        }
    }
}
