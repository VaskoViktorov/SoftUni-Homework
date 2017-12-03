namespace BookShop.Services
{
    using Models.Author;
    using Models.Book;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IAuthorService
    {
        Task<int> CreateAsync(string firstName, string lastName);

        Task<AuthorDetailsServiceModel> DetailsAsync(int id);

        Task<IEnumerable<BookWithCategoriesServiceModel>> BooksAsync(int authorId);

        Task<bool> Exists(int id);
    }
}
