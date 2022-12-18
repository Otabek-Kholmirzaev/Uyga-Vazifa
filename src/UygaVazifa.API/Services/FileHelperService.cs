using UygaVazifa.API.Entities.Enums;

namespace UygaVazifa.API.Services;

public class FileHelperService : IFileHelperService
{
    public async Task<string?> SaveFileAsync(IFormFile file, EFileType fileTypeEnum, EFileFolder fileFolderEnum)
    {
        var fileFolder = fileFolderEnum.ToString();
        var fileType = fileTypeEnum.ToString();
        var path = Path.Combine("wwwroot", fileType, fileFolder);
        
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);

        var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(file.FileName);
        var ms = new MemoryStream();

        await file.CopyToAsync(ms);
        await System.IO.File.WriteAllBytesAsync(Path.Combine(path, fileName), ms.ToArray());

        return fileName;
    }
}