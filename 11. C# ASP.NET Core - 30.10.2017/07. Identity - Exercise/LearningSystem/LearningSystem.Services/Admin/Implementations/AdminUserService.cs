using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LearningSystem.Services.Admin.Implementations
{
    using AutoMapper.QueryableExtensions;
    using Data;
    using Models;
    using System.Collections.Generic;
    using System.Linq;

    public class AdminUserService : IAdminUserService
    {
        private readonly LearningSystemDbContext db;

        public AdminUserService(LearningSystemDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<AdminUserServiceListingModel>> AllAsync()
            => await this.db
                .Users
                .ProjectTo<AdminUserServiceListingModel>()
                .ToListAsync();
    }
}
