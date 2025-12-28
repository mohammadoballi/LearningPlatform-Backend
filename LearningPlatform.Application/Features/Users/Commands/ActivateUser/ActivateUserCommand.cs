using LearningPlatform.Application.Common.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningPlatform.Application.Features.Users.Commands.ActivateUser
{
    public sealed record ActivateUserCommand(Guid UserId) : IRequest<Result>;
}
