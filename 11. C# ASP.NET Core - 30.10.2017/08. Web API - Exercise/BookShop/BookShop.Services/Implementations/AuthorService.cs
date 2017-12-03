namespace BookShop.Services.Implementations
{
    using Models.Book;
    using Models.Author;
    using System.Linq;
    using AutoMapper.QueryableExtensions;
    using Data;
    using System.Threading.Tasks;
    using Data.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;

    class AuthorService : IAuthorService
    {
        private readonly BookShopDbContext db;

        public AuthorService(BookShopDbContext db)
        {
            this.db = db;
        }

        public async Task<int> CreateAsync(string firstName, string lastName)
        {
            var author = new Author
            {
                FirstName = firstName,
                LastName = lastName
            };

            this.db.Add(author);

            await this.db.SaveChangesAsync();

            return author.Id;
        }

        public async Task<AuthorDetailsServiceModel> DetailsAsync(int id)
            => await this.db
                .Authors
                .Where(a => a.Id == id)
                .ProjectTo<AuthorDetailsServiceModel>()
                .FirstOrDefaultAsync();

        public async Task<IEnumerable<BookWithCategoriesServiceModel>> BooksAsync(int authorId)
            => await this.db
                .Books
                .Where(b => b.AuthorId == authorId)
                .ProjectTo<BookWithCategoriesServiceModel>()
                .ToListAsync();

        public async Task<bool> Exists(int id)
            => await this.db
                .Authors
                .AnyAsync(a => a.Id == id);
    }
}
