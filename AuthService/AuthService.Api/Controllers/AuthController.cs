using AuthService.Application.Dto.UserDataTransferObjects;
using AuthService.Application.Features.Users.Requests.Commands;
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
    
    [HttpPost]
    [Route("users")]
    public async Task<ActionResult> CreateUserAsync([FromBody] UserCreateDto userDto, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new CreateUserCommand() { UserDto = userDto }, cancellationToken);
        return CreatedAtRoute(
            routeName: "GetUserById",
            routeValues: new { id = result.Value },
            value: result
            );
    }

    [HttpPost]
    [Route("users/login/email")]
    public async Task<ActionResult> LoginAsync([FromBody] UserLoginWithEmailDto userDto,
        CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new LoginUserWithEmailCommand() { UserDto = userDto }, cancellationToken);
        return Ok(result);
    }
    
    [HttpPost]
    [Route("users/login/username")]
    public async Task<ActionResult> LoginAsync([FromBody] UserLoginWithUserNameDto userDto,
        CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new LoginUserWithUserNameCommand() { UserDto = userDto }, cancellationToken);
        return CreatedAtRoute("GetUserById", result);
    }
}