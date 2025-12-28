using System;
using System.Collections.Generic;
using System.Text;

namespace LearningPlatform.Application.Features.Users.Queries.GetAll
{
    public sealed record UsersDto(
        Guid Id, 
        string Name
        );
}
