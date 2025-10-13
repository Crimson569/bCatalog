using AuthService.Application.Dto.PermissionDataTransferObjects;
using AuthService.Application.Features.Permissions.Requests.Commands;
using AuthService.Application.Features.Permissions.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PermissionController : ControllerBase
{
    private readonly IMediator _mediator;

    public PermissionController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [Route("permissions")]
    public async Task<ActionResult> GetAllPermissionsAsync(CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new GetPermissionsRequest(), cancellationToken);
        return Ok(result);
    }

    [HttpGet]
    [Route("permissions/{id:guid}", Name = "GetPermissionById")]
    public async Task<ActionResult> GetPermissionByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new GetPermissionByIdRequest() { PermissionId = id }, cancellationToken);
        return Ok(result);
    }

    [HttpPost]
    [Route("permissions")]
    public async Task<ActionResult> CreatePermissionAsync([FromBody] PermissionCreateUpdateDto permissionDto,
        CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new CreatePermissionRequest() { PermissionDto = permissionDto },
            cancellationToken);

        return CreatedAtRoute(
            routeName: "GetPermissionById",
            routeValues: new { id = result.Value },
            value: result
            );
    }

    [HttpPut]
    [Authorize(policy: "UpdatePermissionsPolicy")]
    [Route("permissions/{id:guid}")]
    public async Task<ActionResult> UpdatePermissionAsync(Guid id, [FromBody] PermissionCreateUpdateDto permissionDto,
        CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(
            new UpdatePermissionRequest() { PermissionId = id, PermissionDto = permissionDto },
            cancellationToken);

        return Ok(result);
    }

    [HttpDelete]
    [Authorize(policy: "DeletePermissionsPolicy")]
    [Route("permissions/{id:guid}")]
    public async Task<ActionResult> DeletePermissionAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new DeletePermissionRequest() { PermissionId = id }, cancellationToken);
        return Ok(result);
    }
}