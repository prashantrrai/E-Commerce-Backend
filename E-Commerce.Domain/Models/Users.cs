using E_Commerce.Domain.Common;

namespace E_Commerce.Domain.Models
{
    public sealed class Users: BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
