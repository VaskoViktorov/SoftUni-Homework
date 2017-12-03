using System;

namespace BookShop.Services
{
    using System.Threading.Tasks;
    using Models.Book;
    using System.Collections.Generic;

    public interface IBookService
    {
        Task<int> Create(string title, string description, decimal price, int copies, int? edition, int? ageRestriction,
            DateTime releaseDate, int authorId, string categories);

       Task<BookDetailsServiceModel> DetailsAsync(int id);

       Task<IEnumerable<BookListingServiceModel>> All(string searchText);
   }
}
