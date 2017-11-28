using LearningSystem.Common.Mapping;

namespace LearningSystem.Web.Areas.Admin.Models.Users
{
    using System.Collections.Generic;
    using Services.Admin.Models;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Data.Models;

    public class AdminUsersListingViewModel :IMapFrom<User>

    {
    public IEnumerable<AdminUserServiceListingModel> Users { get; set; }

    public IEnumerable<SelectListItem> Roles { get; set; }
    }
}
