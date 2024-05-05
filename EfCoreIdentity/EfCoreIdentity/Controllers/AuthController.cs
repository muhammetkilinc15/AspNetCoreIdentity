using AutoMapper;
using EfCoreIdentity.DTOs.AppUserDto;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly UserManager<AppUser> _userManager;
    private readonly IMapper _mapper;

    public AuthController(UserManager<AppUser> userManager, IMapper mapper)
    {
        _userManager = userManager;
        _mapper = mapper;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto request)
    {
        AppUser user = _mapper.Map<AppUser>(request);
        IdentityResult result = await _userManager.CreateAsync(user, request.Password);
        if (!result.Succeeded)
        {
            return BadRequest(result.Errors.Select(x => x.Description));
        }
        return NoContent();
    }

    [HttpPost("change-password")]
    public async Task<IActionResult> ChangePassword(ChangePasswordDto request)
    {
        AppUser? user = await _userManager.FindByIdAsync(request.userId.ToString());
        if (user == null)
        {
            return BadRequest("User not found");
        }

        IdentityResult result = await _userManager.ChangePasswordAsync(user, request.CurrentPassword, request.NewPassword);
        if (!result.Succeeded)
        {
            return BadRequest(result.Errors.Select(x => x.Description));
        }
        return NoContent();
    }


    [HttpPost("ForgetPassword")]
    public async Task<IActionResult> ForgetPassword(string email, CancellationToken cancellationToken)
    {
        AppUser? user = await _userManager.FindByEmailAsync(email);
        if (user == null)
        {
            return BadRequest("User not found");
        }
        // token oluşturduk
        string token = await _userManager.GeneratePasswordResetTokenAsync(user);
        return Ok(token);

    }
    // CfDJ8Gy6BJlUVHZOv8l8cfO73THtaEQfuhnp7+fAKKrgZtymIOmmrMn7AcsjF3DUpn4N4d0drtjjfgGO+9eDK/SyzkbUdnfbK5mhp7eXJ3tsyZc10fnjzhd/rFBs/6dYy4GdYmqlewczigt6L4boIFbkSOm6149Lel5+El6I+GqXOHzf+1f7+Q9WQfev03rWvs2q1EjMCzP/2uwK3o3hlG/svwJWByw1Ufm9CtN0UO1lpVxz

    [HttpPost("ChangePasswordUsingToken")]
    public async Task<IActionResult> ChangePasswordUsingToken(ChangePasswordRequestTokenDto request, CancellationToken token)
    {
        AppUser? user = await _userManager.FindByEmailAsync(request.Email);
        if (user == null)
        {
            return BadRequest("User not found");
        }
        IdentityResult result = await _userManager.ResetPasswordAsync(user, request.Token, request.NewPassword);
        if (!result.Succeeded)
        {
            return BadRequest(result.Errors.Select(x => x.Description));
        }
        return NoContent();
    }
}
