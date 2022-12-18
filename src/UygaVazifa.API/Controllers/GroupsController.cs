using FurnitureShop.Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UygaVazifa.API.Dtos;
using UygaVazifa.API.Entities;
using UygaVazifa.API.Models;
using UygaVazifa.API.Services;

namespace UygaVazifa.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public partial class GroupsController : ControllerBase
{
    private readonly UserManager<User> _userManager;

    private readonly IGroupService _groupService;

    public GroupsController(IGroupService groupService)
    {
        _groupService = groupService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllGroups([FromQuery] PaginationParams paginationParams) => Ok(await _groupService.GetAllAsync(paginationParams));

    [HttpGet("{groupId:guid}")]
    public async Task<IActionResult> GetGroupById(Guid groupId)
    {
        var existingGroupResult = await _groupService.GetByIdAsync(groupId);
        
        return HandleResultResponseModel(existingGroupResult);
    }

    [HttpPost]
    public async Task<IActionResult> CreateGroup([FromBody] CreateGroupDto dtoModel)
    {
        if(!ModelState.IsValid)
            return BadRequest(ModelState);

        // faqat admin group create qila oladi
        var user = await _userManager.GetUserAsync(User);
        var userGroup = new UserGroup() { UserId = user.Id };

        dtoModel.Users?.Add(userGroup);

        var createdGroupResult = await _groupService.AddAsync(dtoModel);
        
        return HandleResultResponseModel(createdGroupResult);
    }
    
    [HttpPut("{groupId:guid}")]
    public async Task<IActionResult> UpdateGroup(Guid groupId, [FromBody] UpdateGroupDto dtoModel)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var updatedGroupResult = await _groupService.UpdateAsync(groupId, dtoModel);

        return HandleResultResponseModel(updatedGroupResult);
    }

    [HttpDelete("{groupId:guid}")]
    public async Task<IActionResult> DeleteGroup(Guid groupId)
    {
        var deletedGroupResult = await _groupService.RemoveAsync(groupId);

        return HandleResultResponseModel(deletedGroupResult);
    }
    [NonAction]
    private ObjectResult HandleResultResponseModel(Result existingObjectResult)
    {
        if(!existingObjectResult.IsSuccess)
        {
            ObjectResult? errorHandler = existingObjectResult.ErrorCode switch
            {
                StatusCodes.Status404NotFound => NotFound(existingObjectResult),
                _ => BadRequest(existingObjectResult)
            };
            if (errorHandler is not null)
                return errorHandler;
        }
        return Ok(existingObjectResult);
    }
}
