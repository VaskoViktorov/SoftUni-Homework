namespace _02._Social
{
    using Microsoft.EntityFrameworkCore;
    using _02._Social.Data;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Program
    {
        private static readonly Random random = new Random();

        public static void Main()
        {
            using (var db = new SocialNetworkDbContext())
            {
                db.Database.Migrate();
                //SeedInitialData(db);              \\2. Friends
                //PrintAllUsersAndFriends(db);
                //PrintAllActiveUsers(db);
                //SeedAditionalData(db);            \\3. Albums
                //PrintAllAlbums(db);
                //PrintSharedPictures(db);
                //PrintUserSharedAlbums(db);
                //TagCorrector(db);                 \\4. Tags
                //PrintAllAlbumsWithGivenTag(db);
                //PrintAlbumsWithMoreThanThreeTags(db);

                db.SaveChanges();
            }
        }

        private static void SeedInitialData(SocialNetworkDbContext db)
        {
            var currentDate = DateTime.Now;
            DateTime regDate = DateTime.Parse("05.05.2012", CultureInfo.InvariantCulture);
            var totalUsers = 50;
            var addedUsers = new List<Users>();

            //Users
            for (int i = 0; i < totalUsers; i++)
            {
                Users user = new Users()
                {
                    Name = $"User {i}",
                    Password = $"Abcdef%{i}",
                    Email = $"user{1}-email@test.tt",
                    RegistratedOn = regDate.AddDays(i * (i / 2)),
                    LastTimeLoggedIn = currentDate,
                    Age = 15 + i,

                };

                if (i % 5 == 0)
                {
                    user.IsDeleted = true;
                }

                db.Users.Add(user);
                addedUsers.Add(user);
            }

            db.SaveChanges();
            //Users with Friends
            var usersIds = db
                .Users
                .Select(s => s.Id)
                .ToList();

            for (int j = 0; j < totalUsers; j++)
            {
                var currentUser = addedUsers[j];
                var usersFriends = random.Next(2, totalUsers / 5);

                for (int i = 0; i < usersFriends; i++)
                {
                    var userId = usersIds[random.Next(0, usersIds.Count - 1)];
                    if (currentUser.FriendsToMe.All(s => s.UserId != userId && userId != currentUser.Id))
                    {
                        currentUser.FriendsToMe.Add(new UserFriend()
                        {
                            UserId = userId,
                            FriendId = currentUser.Id


                        });
                    }
                    else
                    {
                        i--;
                    }
                }
            }

            db.SaveChanges();
        }

        private static void PrintAllActiveUsers(SocialNetworkDbContext db)
        {
            var result = db
                .Users
                .Where(u => u.IsDeleted == false && u.FriendsOfMine.Count > 5)
                .OrderBy(u => u.RegistratedOn)
                .Select(u => new
                {
                    u.Name,
                    Friends = u.FriendsOfMine.Count,
                    DaysFromRegToNow = u.LastTimeLoggedIn.Subtract(u.RegistratedOn).TotalDays

                }).OrderByDescending(u => u.Friends);

            foreach (var user in result)
            {
                Console.WriteLine($"UserName {user.Name}");
                Console.WriteLine($"FriendsCount {user.Friends}");
                Console.WriteLine($"Member for {user.DaysFromRegToNow:f0} days");
                Console.WriteLine("----------");
            }

        }

        private static void PrintAllUsersAndFriends(SocialNetworkDbContext db)
        {
            var result = db
                .Users
                .Select(u => new
                {
                    u.Name,
                    Friends = u.FriendsOfMine.Count,
                    u.IsDeleted
                })
                .OrderByDescending(u => u.Friends)
                .ThenBy(u => u.Name);

            foreach (var user in result)
            {
                Console.WriteLine($"UserName {user.Name}");
                Console.WriteLine($"FriendsCount {user.Friends}");
                Console.WriteLine(user.IsDeleted ? "Inactive" : "Active");
                Console.WriteLine("----------");
            }
        }

        private static void SeedAditionalData(SocialNetworkDbContext db)
        {
            var totalPictures = 100;
            
            //Pictures
            List<Picture> addedPictures = new List<Picture>();
            for (int j = 0; j < totalPictures; j++)
            {
                Picture picture = new Picture()
                {
                    Title = $"Title {j}",
                    Caption = $"some info {j}",
                    Path = $"url {j}"
                };

                db.Pictures.Add(picture);
                addedPictures.Add(picture);
            }

            db.SaveChanges();

            //Tags
            var totalTags = 60;
            List<Tag> addedTags = new List<Tag>();
            for (int j = 0; j < totalTags; j++)
            {
                Tag tag = new Tag()
                {
                    Content = $"#TestTag {j}"
                };

                db.Tags.Add(tag);
                addedTags.Add(tag);                
            }

            db.SaveChanges();

            //Albums
            var users = db.Users.Select(r => r.Id).ToList();

            for (int i = 0; i < users.Count(); i++)
            {
                var totalAlbums = random.Next(1, 4);

                for (int j = 0; j < totalAlbums; j++)
                {
                    Album album = new Album()
                    {
                        Name = $"Name type {i}",
                        BackgroundColor = $"Color rgb {i}:{i}:{j}",
                        Information = $"some info {i}",
                        UserId = users[i],
                        IsPublic = true
                    };

                    if (i % 5 == 0)
                    {
                        album.IsPublic = false;
                    }

                    db.Albums.Add(album);
                }
            }

            db.SaveChanges();

            //PictureAlbum
            var albumIds = db
                .Albums
                .Select(s => s.Id)
                .ToList();

            for (int j = 0; j < totalPictures; j++)
            {
                var currentPicture = addedPictures[j];
                var picturesInAlbum = random.Next(2, totalPictures / 10);

                for (int i = 0; i < picturesInAlbum; i++)
                {
                    var albumId = albumIds[random.Next(0, albumIds.Count)];
                    if (currentPicture.Albums.All(s => s.AlbumId != albumId))
                    {
                        currentPicture.Albums.Add(new PictureAlbum()
                        {
                            AlbumId = albumId
                        });
                    }
                    else
                    {
                        i--;
                    }
                }

                db.SaveChanges();
            }

            //TagAlbum        
            for (int j = 0; j < totalTags; j++)
            {
                var currentTag = addedTags[j];
                var tagsInAlbum = random.Next(2, totalTags / 20);

                for (int i = 0; i < tagsInAlbum; i++)
                {
                    var albumId = albumIds[random.Next(0, albumIds.Count)];
                    if (currentTag.Albums.All(s => s.AlbumId != albumId))
                    {
                        currentTag.Albums.Add(new TagAlbum()
                        {
                            AlbumId = albumId
                        });
                    }
                    else
                    {
                        i--;
                    }
                }

                db.SaveChanges();
            }

        }

        private static void PrintAllAlbums(SocialNetworkDbContext db)
        {
            var result = db
                .Albums
                .Select(a => new
                {
                    User = a.User.Name,
                    Name = a.Name,
                    PictureCount = a.Pictures.Count
                })
                .OrderByDescending(a => a.PictureCount)
                .ThenBy(a => a.User)
                .ToList();

            foreach (var album in result)
            {
                Console.WriteLine($"Username: {album.User}");
                Console.WriteLine($"Album name: {album.Name}");
                Console.WriteLine($"Pictures in album: {album.PictureCount}");
                Console.WriteLine("------");
            }
        }

        private static void PrintSharedPictures(SocialNetworkDbContext db)
        {
            var result = db
                .Pictures
                .Where(p => p.Albums.Count > 2)
                .OrderByDescending(p => p.Albums.Count)
                .Select(p => new
                {
                    p.Title,
                    Albums = p.Albums.Select(a => new
                    {
                        a.Album.Name,
                        UserName = a.Album.User.Name
                    })

                })
                .OrderBy(p => p.Title)
                .ToList();

            foreach (var picture in result)
            {
                Console.WriteLine($"Picture Title: {picture.Title}");

                foreach (var albums in picture.Albums)
                {
                    Console.WriteLine($"Album name: {albums.Name}");
                    Console.WriteLine($"User name: {albums.UserName}");
                }
            }
        }

        private static void PrintUserSharedAlbums(SocialNetworkDbContext db)
        {
            var userId = random.Next(0, db.Users.Max(u => u.Id));
            var result = db
                .Albums
                .Where(a => a.UserId == userId)
                .Select(a => new
                {
                    a.Name,
                    a.IsPublic,
                    Pictures = a.Pictures.Select(p => new
                    {
                        p.Picture.Title,
                        p.Picture.Path
                    })
                })
                .OrderBy(a => a.Name);

            foreach (var album in result)
            {
                Console.WriteLine($"Album Name: {album.Name}");

                if (album.IsPublic)
                {
                    foreach (var picture in album.Pictures)
                    {
                        Console.WriteLine($"-Title: {picture.Title}");
                        Console.WriteLine($"---path: {picture.Path}");
                    }
                }
                else
                {
                    Console.WriteLine("Private content!");
                }
            }
        }

        private static void TagCorrector(SocialNetworkDbContext db)
        {
            string input = Console.ReadLine();

            input = TagTransformer.Transform(input);

            Tag tag = new Tag { Content = input };

            db.Tags.Add(tag);

            Console.WriteLine($"{input} was added to database");
        }


        private static void PrintAllAlbumsWithGivenTag(SocialNetworkDbContext db)
        {
            var specificTagId = 42;

            var result = db
                .Albums
                .OrderByDescending(a => a.Tags.Count)
                .ThenBy(a => a.Name)
                .Select(a => new
                {
                    Tag = a.Tags.Where(t => t.Tag.Id == specificTagId).Select(t => new
                    {
                        t.Album.Name,
                        User = t.Album.User.Name
                    }),
                })
                .ToList();

            foreach (var album in result)
            {
                foreach (var tag in album.Tag)
                {
                    Console.WriteLine($"Album Name: {tag.Name}");
                    Console.WriteLine($"Username: {tag.User}");
                    Console.WriteLine("-----");
                }
            }
        }

        private static void PrintAlbumsWithMoreThanThreeTags(SocialNetworkDbContext db)
        {
            var result = db
                .Users
                .OrderByDescending(u => u.Albums.Count)
                .Select(u => new
                {
                    Tags = u
                    .Albums
                    .OrderByDescending(x => x.Tags.Count)
                    .ThenBy(x => x.Name)
                    .Where(a => a.Tags.Count > 3)
                    .Select(t => new
                    {
                        t.User.Name,
                        Album = t.Name,
                        Tags = t.Tags.Select(a => a.Tag.Content)
                    })

                })
                
                .ToList();

            foreach (var user in result)
            {
                foreach (var album in user.Tags)
                {
                    Console.WriteLine($"Username: {album.Name}");
                    Console.WriteLine($"Album name: {album.Album}");

                    foreach (var tag in album.Tags)
                    {
                        Console.WriteLine($"--{tag}");
                    }

                    Console.WriteLine("----");
                }
            }
        }

    }
}
