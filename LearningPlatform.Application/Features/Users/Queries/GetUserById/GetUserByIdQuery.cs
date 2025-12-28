using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningPlatform.Application.Features.Users.Queries.GetUserById
{
    public sealed record GetUserByIdQuery(Guid UserId) : IRequest<UserDto?>;
}
