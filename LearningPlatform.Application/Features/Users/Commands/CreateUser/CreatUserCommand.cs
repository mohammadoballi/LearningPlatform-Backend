using MediatR;
using LearningPlatform.Application.Common.Results;

namespace LearningPlatform.Application.Features.Users.Commands.CreateUser
{
  
    public sealed record CreateUserCommand(
        string FullName,
        string Email,
        string Phone
    ) : IRequest<Result>;

}
