using Microsoft.AspNetCore.Http;

namespace Shared.Interfaces;

public interface IFileService
{
    Task<string> SaveFileAsync(IFormFile file, string? directory = null);
    Task<Stream> GetFileAsync(string path);
    Task DeleteFileAsync(string path);
    Task<bool> FileExistsAsync(string path);
}