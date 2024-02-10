// Response class

namespace E_Commerce.Services.Features.UserFeatures.CreateUsers
{
    public sealed record CreateUserResponse
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}