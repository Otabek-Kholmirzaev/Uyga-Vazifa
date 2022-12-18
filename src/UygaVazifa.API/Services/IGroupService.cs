using FurnitureShop.Common.Models;
using UygaVazifa.API.Dtos;
using UygaVazifa.API.Models;

namespace UygaVazifa.API.Services;

public interface IGroupService
{
    Task<Result<List<GroupResponseModel>>> GetAllAsync(PaginationParams paginationParams);
    Task<Result<GroupResponseModel>> GetByIdAsync(Guid groupId);
    Task<Result> AddAsync(CreateGroupDto dtoModel);
    Task<Result> RemoveAsync(Guid groupId);
    Task<Result<GroupResponseModel>> UpdateAsync(Guid groupId, UpdateGroupDto dtoModel);
}