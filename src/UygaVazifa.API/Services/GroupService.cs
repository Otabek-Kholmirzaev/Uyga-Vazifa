using FurnitureShop.Common.Helpers;
using FurnitureShop.Common.Models;
using Mapster;
using UygaVazifa.API.Dtos;
using UygaVazifa.API.Entities;
using UygaVazifa.API.Entities.Enums;
using UygaVazifa.API.Models;
using UygaVazifa.API.Repositories.Interfaces;

namespace UygaVazifa.API.Services;

public class GroupService : IGroupService
{
    private readonly IGenericRepository<Group> _groupsRepository;

    public GroupService(IGenericRepository<Group> groupsRepository)
    {
        _groupsRepository = groupsRepository;
    }

    public async Task<Result<List<GroupResponseModel>>> GetAllAsync(PaginationParams paginationParams)
    {
        var groups = (await _groupsRepository.GetAll()
            .ToPagedListAsync(paginationParams)).ToList();
        if (groups.Count == 0)
            return new("There is no any pages");
        
        return new(true) { Data = groups.Adapt<List<GroupResponseModel>>() };
    }

    public async Task<Result<GroupResponseModel>> GetByIdAsync(Guid groupId)
    {
        var existingGroup = _groupsRepository.GetById(groupId);
        if (existingGroup is null)
            return new("The group with given id is not found") { ErrorCode = StatusCodes.Status404NotFound };

        return new(true) { Data = existingGroup.Adapt<GroupResponseModel>() };
    }

    public async Task<Result> AddAsync(CreateGroupDto dtoModel)
    {
        var entity = dtoModel.Adapt<Group>();
        entity.Status = EGroupStatus.Created;

        await _groupsRepository.AddAsync(entity);

        return new(true);
    }

    public async Task<Result> RemoveAsync(Guid groupId)
    {
        var existingGroup = _groupsRepository.GetById(groupId);
        if (existingGroup is null)
            return new("The group with given id is not found") { ErrorCode = StatusCodes.Status404NotFound };
        
        existingGroup.Status = EGroupStatus.Deleted;
        await _groupsRepository.Update(existingGroup);

        return new(true);
    }

    public async Task<Result<GroupResponseModel>> UpdateAsync(Guid groupId, UpdateGroupDto dtoModel)
    {
        var existingGroup = _groupsRepository.GetById(groupId);
        if (existingGroup is null)
            return new("The group with given id is not found") { ErrorCode = StatusCodes.Status404NotFound };

        existingGroup = dtoModel.Adapt<Group>();

        return new(true) { Data = existingGroup.Adapt<GroupResponseModel>() };
    }
}