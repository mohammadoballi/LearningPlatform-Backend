using LearningPlatform.Application.Abstractions.Repositories.UserRepos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningPlatform.Application.Features.Users.Queries.GetAll
{
    public class GetAllQueryHandler : IRequestHandler<GetAllQuery, List<UsersDto>>
    {

        private readonly IUserRepository _userRepository;
        public GetAllQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<UsersDto>> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
            var users =await _userRepository.GetAllAsync(request, cancellationToken);

            var finalusers = users.Select(u => new UsersDto(u.Id, u.FullName.Value)).ToList();

            return finalusers;
        }
    }
}
