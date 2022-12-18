using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using UygaVazifa.API.Dtos;
using UygaVazifa.API.Entities;
using UygaVazifa.API.Models;
using SignInResult = Microsoft.AspNetCore.Mvc.SignInResult;

namespace UygaVazifa.API.Controllers;
[ApiController]
[Route("api/[controller]")]
public class AccountsController : ControllerBase
{
    private readonly SignInManager<User> _signInManager;
    private readonly UserManager<User> _userManager;
    private readonly RoleManager<Role> _roleManager;

    public AccountsController(SignInManager<User> signInManager, UserManager<User> userManager, RoleManager<Role> roleManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
        _roleManager = roleManager;
    }
    [HttpGet("signIn")]
    public async Task<IActionResult> SignIn(SignInUserDto dtoModel)
    {
        if (!ModelState.IsValid)
            return BadRequest("");
        var user = dtoModel.Adapt<User>();

        var signInResult = await _signInManager.PasswordSignInAsync(user, dtoModel.Password, true , true);
        
        if (!signInResult.Succeeded)
        {
            signInResult.Adapt<Result<SignInResult>>().ErrorMessage = $"The error occured at {nameof(AccountsController)}";
            return BadRequest(signInResult.Adapt<Result<SignInResult>>());
        }

        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> SignUp(CreateUserDto dtoModel)
    {
        if (!ModelState.IsValid)
            return BadRequest("");
        
        var user = dtoModel.Adapt<User>();
        var result = await _userManager.CreateAsync(user, dtoModel.Password);

        if (!result.Succeeded)
            return BadRequest();
        
        await _signInManager.SignInAsync(user, true);

        return Ok();
    }

    [HttpPost("signOut")]
    public async Task<IActionResult> SignOut()
    {
        await _signInManager.SignOutAsync();

        return Ok();
    }
}