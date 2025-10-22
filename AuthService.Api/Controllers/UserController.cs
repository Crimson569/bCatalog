using AuthService.Api.Extensions;
using AuthService.Application.Dto.UserDataTransferObjects;
using AuthService.Application.Features.Users.Requests.Commands;
using AuthService.Application.Features.Users.Requests.Queries;
using AuthService.Infrastructure.Implementations.Auth;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
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
    [Route("users/{id:guid}", Name = "GetUserById")]
    public async Task<ActionResult> GetUserByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new GetUserByIdRequest(){UserId = id}, cancellationToken);
        return Ok(result);
    }
    
    [HttpPost]
    [Route("users/{userId:guid}/roles")]
    public async Task<ActionResult> AddRoleToUserAsync(Guid userId, [FromBody] UserAddRoleDto userAddRoleDto,
        CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(
            new AddRoleToUserCommand()
            {
                UserId = userId,
                UserAddRoleDto = userAddRoleDto
            }, 
            cancellationToken);

        return Ok(result);
    }

    [HttpPost]
    [Route("users/{userId:guid}/avatar")]
    public async Task<ActionResult> SetUserAvatarAsync(Guid userId, [FromForm]UserSetAvatarDto userSetAvatarDto, CancellationToken cancellationToken)
    {
        var currentUserId = HttpContext.GetCurrentUserId();

        if (currentUserId == null || currentUserId != userId)
        {
            return Forbid();
        }
        
        var result = await _mediator.Send(new SetUserAvatarCommand { UserId = userId, UserSetAvatarDto = userSetAvatarDto },
            cancellationToken);
        return Ok(result);
    }
    
    [HttpDelete]
    [Route("users/{userId:guid}/roles")]
    public async Task<ActionResult> RemoveRoleFromUserAsync(Guid userId, [FromBody] UserRemoveRoleDto userRemoveRoleDto,
        CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(
            new RemoveRoleFromUserCommand()
            {
                UserId = userId,
                UserRemoveRoleDto = userRemoveRoleDto
            }, 
            cancellationToken);

        return Ok(result);
    }
    
    [HttpPut]
    [Authorize(policy: "UpdateUsersPolicy")]
    [Route("users/{id:guid}")]
    public async Task<ActionResult> UpdateUserAsync([FromBody] UserUpdateDto userDto,
        CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new UpdateUserCommand() { UserDto = userDto }, cancellationToken);
        return Ok(result);
    }

    [HttpDelete]
    [Authorize(policy: "DeleteUsersPolicy")]
    [Route("users/{id:guid}")]
    public async Task<ActionResult> DeleteUserByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new DeleteUserCommand() { UserId = id }, cancellationToken);
        return Ok(result);
    }
}