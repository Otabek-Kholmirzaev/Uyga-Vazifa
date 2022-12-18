using FurnitureShop.Common.Models;
using UygaVazifa.API.Dtos;
using UygaVazifa.API.Models;

namespace UygaVazifa.API.Services;

public interface IHomeworksService
{
    Task<Result<List<HomeworkResponseModel>>> GetAllAsync(PaginationParams paginationParams);
    Task<Result<HomeworkResponseModel>> GetByIdAsync(Guid homeworkId);
    Task<Result> AddAsync(CreateHomeworkDto dtoModel);
    Task<Result> RemoveAsync(Guid groupId);
    Task<Result<HomeworkResponseModel>> UpdateAsync(Guid homeworkId, UpdateGroupDto dtoModel);
}