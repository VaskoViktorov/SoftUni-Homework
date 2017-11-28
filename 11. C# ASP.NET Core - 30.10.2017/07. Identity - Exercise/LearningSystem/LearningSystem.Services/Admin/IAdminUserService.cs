using System.Threading.Tasks;

namespace LearningSystem.Services.Admin
{
    using System.Collections.Generic;
    using Models;

    public interface IAdminUserService
   {
       Task<IEnumerable<AdminUserServiceListingModel>> AllAsync();
   }
}
