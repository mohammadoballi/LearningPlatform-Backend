using System;
using System.Collections.Generic;
using System.Text;

namespace LearningPlatform.Application.Features.Users.Queries.GetUserById
{
    public sealed record UserDto(
       Guid Id,
       string FullName,
       string Email,
       string Phone,
       bool IsActive
   );
}
