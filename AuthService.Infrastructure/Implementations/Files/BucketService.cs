using AuthService.Application.Interfaces.Files;
using AuthService.Infrastructure.Options;
using Microsoft.Extensions.Options;
using Minio;
using Minio.DataModel.Args;

namespace AuthService.Infrastructure.Implementations.Files;

public class BucketService : IBucketService
{
    private readonly IMinioClient _minioClient;
    private readonly BucketOptions _bucketOptions;

    public BucketService(IMinioClient minioClient, IOptions<BucketOptions> bucketOptions)
    {
        _minioClient = minioClient;
        _bucketOptions = bucketOptions.Value;
    }

    public async Task CreateBucketAsync()
    {
        var bucketName = _bucketOptions.Name;
        var beArgs = new BucketExistsArgs().WithBucket(bucketName);
        bool found = await _minioClient.BucketExistsAsync(beArgs);

        if (!found)
        {
            var mbArgs = new MakeBucketArgs().WithBucket(bucketName);

            await _minioClient.MakeBucketAsync(mbArgs);
        }
    }
}