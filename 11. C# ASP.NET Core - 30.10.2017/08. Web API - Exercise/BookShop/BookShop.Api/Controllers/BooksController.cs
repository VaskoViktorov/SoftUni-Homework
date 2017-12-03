namespace BookShop.Api.Controllers
{
    using Services;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Infrastructure.Extensions;
    using Models.Books;
    using Infrastructure.Filters;

    using static WebConstants;

    public class BooksController : BaseApiController
    {
        private readonly IBookService books;
        private readonly IAuthorService authors;

        public BooksController(IBookService books, IAuthorService authors)
        {
            this.books = books;
            this.authors = authors;
        }

        [HttpGet(WithId)]
        public async Task<IActionResult> Get(int id)
            => this.OkOrNotFound(await this.books.DetailsAsync(id));

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]string searchText)
            => this.Ok(await this.books.All(searchText));

        [HttpPost]
        [ValidateModelState]
        public async Task<IActionResult> Post([FromBody] CreateBookRequestModel model)
        {
            if (!await this.authors.Exists(model.AuthorId))
            {
                return this.BadRequest("Author does not exist.");
            }

            var id = await this.books.Create(
                model.Title,
                model.Description,
                model.Price,
                model.Copies,
                model.Edition,
                model.AgeRestriction,
                model.ReleaseDate,
                model.AuthorId,
                model.Categories);

            return this.Ok(id);
        }
    }
}
