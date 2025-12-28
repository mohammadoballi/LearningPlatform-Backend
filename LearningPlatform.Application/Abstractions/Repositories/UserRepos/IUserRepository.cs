using LearningPlatform.Application.Common.Results;
using LearningPlatform.Application.Features.Users.Commands.CreateUser;
using LearningPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningPlatform.Application.Abstractions.Repositories.UserRepos
{
    public interface IUserRepository
    {
        Task AddAsync(User user, CancellationToken token);
        Task<User> GetByIdAsync(Guid UserId, CancellationToken token);
    }
}
