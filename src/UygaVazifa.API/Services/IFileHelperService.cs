using UygaVazifa.API.Entities.Enums;

namespace UygaVazifa.API.Services;

public interface IFileHelperService
{
    Task<string?> SaveFileAsync(IFormFile file, EFileType fileTypeEnum, EFileFolder fileFolderEnum);
}