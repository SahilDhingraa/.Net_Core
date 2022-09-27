using AutoMapper;
using udemy1.Dtos.Character;
using udemy1.Dtos.Weapon;

namespace udemy1
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<UpdateCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
        } 
    }
}