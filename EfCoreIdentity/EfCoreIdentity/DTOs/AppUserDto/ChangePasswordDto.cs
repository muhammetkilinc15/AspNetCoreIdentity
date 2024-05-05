namespace EfCoreIdentity.DTOs.AppUserDto
{
    public sealed record ChangePasswordDto
    (
        Guid userId ,
        string CurrentPassword,
        string NewPassword
     );
}
