using AuthService.Application.Dto.RoleDataTransferObjects;
using AuthService.Application.Features.Roles.Requests.Commands;
using AuthService.Application.Features.Roles.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RoleController : ControllerBase
{
    private readonly IMediator _mediator;

    public RoleController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [Route("roles")]
    public async Task<ActionResult> GetAllRolesAsync(CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new GetRolesRequest(), cancellationToken);
        return Ok(result);
    }

    [HttpGet]
    [Route("roles/{id:guid}")]
    public async Task<ActionResult> GetRoleByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new GetRoleByIdRequest() { RoleId = id }, cancellationToken);
        return Ok(result);
    }

    [HttpPost]
    [Route("roles")]
    public async Task<ActionResult> CreateRoleAsync([FromBody] RoleCreateUpdateDto roleDto,
        CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new CreateRoleCommand() { RoleDto = roleDto }, cancellationToken);
        return Ok(result); //Заменить на Created
    }

    [HttpPost]
    [Route("roles/{roleId:guid}/permissions")]
    public async Task<ActionResult> AddPermissionToRoleAsync(Guid roleId,
        [FromBody] RoleAddPermissionDto roleAddPermissionDto, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(
            new AddPermissionToRoleCommand() { RoleId = roleId, PermissionId = roleAddPermissionDto.PermissionId },
            cancellationToken);

        return Ok(result);
    }

    [HttpPut]
    [Authorize(policy: "UpdateRolesPolicy")]
    [Route("roles/{id:guid}")]
    public async Task<ActionResult> UpdateRoleAsync([FromBody] RoleCreateUpdateDto roleDto, Guid id,
        CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new UpdateRoleCommand() { RoleDto = roleDto, RoleId = id}, cancellationToken);
        return Ok(result);
    }

    [HttpDelete]
    [Route("roles/{id:guid}")]
    public async Task<ActionResult> DeleteRoleAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new DeleteRoleCommand() { RoleId = id }, cancellationToken);
        return Ok(result);
    }
    
    [HttpDelete]
    [Authorize(policy: "DeleteRolesPolicy")]
    [Route("roles/{roleId:guid}/permissions")]
    public async Task<ActionResult> RemovePermissionFromRoleAsync(Guid roleId,
        [FromBody] RoleRemovePermissionDto roleRemovePermissionDto, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(
            new RemovePermissionFromRoleCommand() { RoleId = roleId, PermissionId = roleRemovePermissionDto.PermissionId },
            cancellationToken);

        return Ok(result);
    }
    
}