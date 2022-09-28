using Microsoft.AspNetCore.Mvc;
using udemy1.Dtos.Fight;
using udemy1.Services.CharacterService;
using udemy1.Services.FightService;

namespace udemy1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FightController : ControllerBase
    {
        private readonly IFightService _fightService;
        public FightController(IFightService fightService)
        {
            _fightService = fightService;
            
        }
        [HttpPost("Weapon")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> WeaponAttack(WeaponAttackDto request)
        {
            return Ok(await _fightService.WeaponAttack(request));
        }
        [HttpPost("Skill")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> SkillAttack(SkillAtttackDto request)
        {
            return Ok(await _fightService.SkillAttack(request));
        }
    }
}