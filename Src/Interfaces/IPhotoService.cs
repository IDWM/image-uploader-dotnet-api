using CloudinaryDotNet.Actions;

namespace image_uploader_dotnet_api.Src.Interfaces;

public interface IPhotoService
{
    Task<ImageUploadResult> AddPhotoAsync(IFormFile file);
    Task<DeletionResult> DeletePhotoAsync(string publicId);
}