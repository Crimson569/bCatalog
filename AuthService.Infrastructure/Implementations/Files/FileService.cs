using AuthService.Infrastructure.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Minio;
using Minio.DataModel.Args;
using Shared.Interfaces;

namespace AuthService.Infrastructure.Implementations.Files;

public class FileService : IFileService
{
    private readonly IMinioClient _minioClient;
    private readonly BucketOptions _bucketOptions;

    public FileService(IMinioClient minioClient, IOptions<BucketOptions> bucketOptions)
    {
        _minioClient = minioClient;
        _bucketOptions = bucketOptions.Value;
    }

    public async Task<string> SaveFileAsync(IFormFile file, string? directory = null)
    {
        var folder = string.IsNullOrWhiteSpace(directory) ? _bucketOptions.FolderName : directory;
        
        var objectName = string.IsNullOrWhiteSpace(folder) 
            ? file.FileName 
            : $"{folder}/{Guid.NewGuid()}";
        
        var contentType = file.ContentType ?? "application/octet-stream";
        
        await using var fileStream = file.OpenReadStream();

        var putObjectArgs = new PutObjectArgs()
            .WithBucket(_bucketOptions.Name)
            .WithObject(objectName)
            .WithStreamData(fileStream)
            .WithObjectSize(fileStream.Length)
            .WithContentType(contentType);

        await _minioClient.PutObjectAsync(putObjectArgs);

        return objectName; 
    }


    public async Task<Stream> GetFileAsync(string path)
    {
        var memoryStream = new MemoryStream();

        var getObjectArgs = new GetObjectArgs()
            .WithBucket(_bucketOptions.Name)
            .WithObject(path)
            .WithCallbackStream(s => s.CopyTo(memoryStream));

        await _minioClient.GetObjectAsync(getObjectArgs);
        memoryStream.Position = 0;

        return memoryStream;
    }


    public async Task DeleteFileAsync(string path)
    {
        await _minioClient.RemoveObjectAsync(new RemoveObjectArgs()
            .WithBucket(_bucketOptions.Name)
            .WithObject(path));
    }

    public async Task<bool> FileExistsAsync(string path)
    {
        try
        {
            await _minioClient.StatObjectAsync(
                new StatObjectArgs()
                    .WithBucket(_bucketOptions.Name)
                    .WithObject(path));
            return true;
        }
        catch (Minio.Exceptions.ObjectNotFoundException)
        {
            return false;
        }
    }

}