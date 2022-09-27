using udemy1.Dtos.Character;
using udemy1.Dtos.Weapon;
using udemy1.Services.CharacterService;

namespace udemy1.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}