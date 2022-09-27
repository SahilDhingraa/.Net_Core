using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using udemy1.Dtos.Character;
using udemy1.Dtos.Weapon;
using udemy1.Services.CharacterService;
using udemy1.Services.WeaponService;

namespace udemy1.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeaponController : ControllerBase
    {
        private readonly IWeaponService _weaponSevice;

        public WeaponController(IWeaponService weaponSevice)
        {
            _weaponSevice = weaponSevice;
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddWeapon(AddWeaponDto newWeapon)
        {
            return Ok(await _weaponSevice.AddWeapon(newWeapon));
        }
    }
}