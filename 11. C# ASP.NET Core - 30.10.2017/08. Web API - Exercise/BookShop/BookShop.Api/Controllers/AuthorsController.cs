namespace BookShop.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Infrastructure.Extensions;
    using Services;
    using System.Threading.Tasks;
    using Models.Authors;
    using Infrastructure.Filters;

    using static WebConstants;

    public class AuthorsController : BaseApiController
    {
        private readonly IAuthorService authors;

        public AuthorsController(IAuthorService authors)
        {
            this.authors = authors;
        }

        [HttpGet(WithId)]
        public async Task<IActionResult> Get(int id)
            => this.OkOrNotFound(await this.authors.DetailsAsync(id));

        [HttpGet(WithId + "/books")]
        public async Task<IActionResult> GetBooks(int id)
            => this.Ok(await this.authors.BooksAsync(id));

        [HttpPost]
        [ValidateModelState]
        public async Task<IActionResult> Post([FromBody]AuthorRequestModel model)
            => this.Ok(await this.authors.CreateAsync(model.FirstName, model.LastName));
        

    }
}
