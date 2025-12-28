using System;
using System.Collections.Generic;
using System.Text;
using LearningPlatform.Application.Abstractions.Repositories.UserRepos;
using LearningPlatform.Application.Common.Results;
using LearningPlatform.Domain.Entities;
using LearningPlatform.Domain.ValueObjects.UserObjects;
using MediatR;
namespace LearningPlatform.Application.Features.Users.Commands.CreateUser
{
    public sealed class CreatUserCommandHandler:IRequestHandler<CreateUserCommand , Result>
    {
        private readonly IUserRepository _userRepository;
        public CreatUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Result> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var fullname = new FullName(request.FullName);
            var email = new Email(request.Email);
            var phone = new PhoneNumber(request.Phone);

            var user = new User(fullname, email, phone);

            await _userRepository.AddAsync(user, cancellationToken);

            return Result.Success();
        }
    }
}
