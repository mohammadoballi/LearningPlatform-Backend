using LearningPlatform.Application.Abstractions.Repositories.UserRepos;
using LearningPlatform.Application.Common.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningPlatform.Application.Features.Users.Commands.ActivateUser
{
    public class ActivateUserCommandHandler :IRequestHandler<ActivateUserCommand , Result>
    {
        private readonly IUserRepository _userRepository;
        public ActivateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Result> Handle(ActivateUserCommand request, CancellationToken cancellationToken)
        {
            // Implementation for activating a user goes here.
            // This is a placeholder implementation.
            return Result.Success();
        }
    }
}
