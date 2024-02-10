//Request Class

using MediatR;

namespace E_Commerce.Services.Features.UserFeatures.CreateUsers;
    public sealed record CreateUserRequest(string Email, string Name) : IRequest<CreateUserResponse>;