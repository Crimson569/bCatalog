namespace AuthService.Infrastructure.Options;

public class BucketOptions
{
    public string Name { get; set; } = string.Empty;
    public string FolderName { get; set; } = string.Empty;
    public int ExpirationTimeSeconds { get; set; }
}