// Handler class

using AutoMapper;
using E_Commerce.Domain.Models;
using E_Commerce.Services.Repositories;
using MediatR;

namespace E_Commerce.Services.Features.UserFeatures.CreateUsers
{
    public sealed class CreateUserHandler : IRequestHandler<CreateUserRequest, CreateUserResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        // dependency injecting
        public CreateUserHandler(IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<Users>(request);
            _userRepository.Create(user);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<CreateUserResponse>(user);
        }
    }

}
