using LearningPlatform.Application.Abstractions.Repositories.UserRepos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningPlatform.Application.Features.Users.Queries.GetUserById
{
    public sealed class GetUserByIdQueryHandler:IRequestHandler<GetUserByIdQuery , UserDto?>
    {
        private readonly IUserRepository _userRepository;
        public GetUserByIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDto?> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.UserId, cancellationToken);
            if (user is null)
            {
                return null;
            }
            return new UserDto(
             user.Id,
             user.FullName.Value,
             user.Email.Value,
             user.Phone.Value,
             user.IsActive
         );

        }
    }
}
