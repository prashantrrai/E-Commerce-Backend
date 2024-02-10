// IUserRepository interface

using E_Commerce.Domain.Models;

namespace E_Commerce.Services.Repositories
{
    public interface IUserRepository : IBaseRepository<Users>
    {
        Task<Users> GetByEmail(string email, CancellationToken cancellationToken);
    }
}
