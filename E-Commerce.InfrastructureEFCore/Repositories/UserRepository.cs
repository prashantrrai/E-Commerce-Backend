// UserRepository class

using E_Commerce.Domain.Models;
using E_Commerce.Infrastructure.Persistence.Context;
using E_Commerce.Services.Repositories;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Infrastructure.Persistence.Repositories
{
    public class UserRepository : BaseRepository<Users>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context) { }

        public Task<Users> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
        }
    }
}
