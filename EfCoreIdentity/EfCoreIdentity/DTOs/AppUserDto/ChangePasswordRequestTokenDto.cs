namespace EfCoreIdentity.DTOs.AppUserDto
{
    public sealed record ChangePasswordRequestTokenDto
   (
        string Email,
        string NewPassword,
        string Token
    );
}
