using FurnitureShop.Common.Models;
using UygaVazifa.API.Dtos;
using UygaVazifa.API.Entities;
using UygaVazifa.API.Models;
using UygaVazifa.API.Repositories.Interfaces;

namespace UygaVazifa.API.Services;

public class HomeworkService : IHomeworksService
{
    private readonly IGenericRepository<Homework> _homeworkRepository;

    public HomeworkService(IGenericRepository<Homework> homeworkRepository)
    {
        _homeworkRepository = homeworkRepository;
    }

    public async Task<Result<List<HomeworkResponseModel>>> GetAllAsync(PaginationParams paginationParams)
    {
        throw new NotImplementedException();
    }

    public async Task<Result<HomeworkResponseModel>> GetByIdAsync(Guid homeworkId)
    {
        throw new NotImplementedException();
    }

    public async Task<Result> AddAsync(CreateHomeworkDto dtoModel)
    {
        throw new NotImplementedException();
    }

    public async Task<Result> RemoveAsync(Guid groupId)
    {
        throw new NotImplementedException();
    }

    public async Task<Result<HomeworkResponseModel>> UpdateAsync(Guid homeworkId, UpdateGroupDto dtoModel)
    {
        throw new NotImplementedException();
    }
}