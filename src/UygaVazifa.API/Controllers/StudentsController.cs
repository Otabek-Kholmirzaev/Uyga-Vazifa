using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using UygaVazifa.API.Data;
using UygaVazifa.API.Entities;

namespace UygaVazifa.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly UserManager<User> _userManager;

    public StudentsController(AppDbContext context, UserManager<User> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    [HttpGet]
    public async Task<IActionResult> GetHomeworksTable()
    {
        var user = await _userManager.GetUserAsync(User);

        if (user is null)
            return Ok(new List<object>());

        var homeworkDetails = new List<object>();

        var homeworks = _context.Homeworks.Include(x => x.UserHomeworks).Where(x => x.UserHomeworks.Any(y => y.UserId == user.Id)).ToList();

        foreach (var homework in homeworks)
        {
            homeworkDetails.Add(new
            {
                Date = homework.StartDate,
                Title = homework.Title,
            });
        }

        return Ok(homeworkDetails);
    }
}
