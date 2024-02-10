// Entity Framework DataContext class

using E_Commerce.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Infrastructure.Persistence.Context;
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<Users> Users { get; set; }
    }
