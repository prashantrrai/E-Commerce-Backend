// IUnitOfWork interface

namespace E_Commerce.Services.Repositories
{
    public interface IUnitOfWork
    {
        Task Save(CancellationToken cancellationToken);
    }
}
