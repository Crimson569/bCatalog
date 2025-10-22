namespace AuthService.Api.Extensions;

public static class HttpContextExtensions
{
    public static Guid? GetCurrentUserId(this HttpContext httpContext)
    {
        var currentUserId = httpContext.User.FindFirst("sub")?.Value;
        return Guid.TryParse(currentUserId, out var guid) ? guid : null;
    }
}