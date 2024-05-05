using AutoMapper;
using EfCoreIdentity.DTOs.AppUserDto;
using EntityLayer.Concreate;

namespace EfCoreIdentity.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterDto,AppUser>().ReverseMap();
            CreateMap<ChangePasswordDto,AppUser>().ReverseMap();
        }
    }
}
