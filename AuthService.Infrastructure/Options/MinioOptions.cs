namespace AuthService.Infrastructure.Options;

public class MinioOptions
{
    public string AccessKey { get; set; } = string.Empty;
    public string SecretKey { get; set; } = string.Empty;
    public string Enpoint { get; set; } = string.Empty;
}