using AuthService.Application.Features.Users.Requests.Commands;
using AuthService.Application.Features.Users.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IMediator _mediator;

    public AuthController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [Route("users")]
    public async Task<ActionResult> GetAllUsersAsync(CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new GetUsersRequest(), cancellationToken);
        return Ok(result);
    }

    [HttpGet]
    [Route("users/{id:guid}")]
    public async Task<ActionResult> GetUserByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new GetUserByIdRequest(){UserId = id}, cancellationToken);
        return Ok(result);
    }

    [HttpDelete]
    [Route("users/{id:guid}")]
    public async Task<ActionResult> DeleteUserByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new DeleteUserCommand() { UserId = id }, cancellationToken);
        return Ok(result);
    }
}