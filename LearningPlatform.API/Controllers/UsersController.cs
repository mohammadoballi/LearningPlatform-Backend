using LearningPlatform.Application.Features.Users.Commands.ActivateUser;
using LearningPlatform.Application.Features.Users.Commands.CreateUser;
using LearningPlatform.Application.Features.Users.Queries.GetAll;
using LearningPlatform.Application.Features.Users.Queries.GetUserById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningPlatform.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserCommand command)
        {
            var result = await _mediator.Send(command);

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok();
        }

        [HttpPost("{id:guid}/activate")]
        public async Task<IActionResult> Activate(Guid id)
        {
            var result = await _mediator.Send(new ActivateUserCommand(id));

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok();
        }


    [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _mediator.Send(new GetUserByIdQuery(id));

            if (result is null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll ()
        {
            var result = await _mediator.Send(new GetAllQuery());

            if (result is null)
                return NotFound();

            return Ok(result);
        }

    }
}