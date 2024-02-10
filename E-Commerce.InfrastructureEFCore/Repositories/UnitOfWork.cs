// UnitOfWork class

using E_Commerce.Infrastructure.Persistence.Context;
using E_Commerce.Services.Repositories;

namespace E_Commerce.Infrastructure.Persistence.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly DataContext _context;
        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public Task Save(CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}
