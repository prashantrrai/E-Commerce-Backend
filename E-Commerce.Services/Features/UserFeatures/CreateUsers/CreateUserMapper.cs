// Mapper class

using AutoMapper;
using E_Commerce.Domain.Models;

namespace E_Commerce.Services.Features.UserFeatures.CreateUsers
{
    public sealed class CreateUserMapper: Profile
    {
        public CreateUserMapper()
        {
            CreateMap<CreateUserRequest, Users>();
            CreateMap<Users, CreateUserResponse>();
        }
    }
}
