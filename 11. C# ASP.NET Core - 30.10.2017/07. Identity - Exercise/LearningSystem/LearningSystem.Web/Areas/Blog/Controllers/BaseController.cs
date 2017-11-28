namespace LearningSystem.Web.Areas.Blog.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;

    using static WebConstants;

    [Area(BlogAreaName)]
    [Authorize(Roles = BlogAuthorRole)]
    public class BaseController : Controller
    {
    }
}


