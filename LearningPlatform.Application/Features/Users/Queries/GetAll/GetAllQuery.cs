using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningPlatform.Application.Features.Users.Queries.GetAll
{
   public sealed record GetAllQuery() :IRequest<List<UsersDto>>;
}
