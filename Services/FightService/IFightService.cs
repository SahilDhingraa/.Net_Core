using udemy1.Dtos.Fight;
using udemy1.Services.CharacterService;

namespace udemy1.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
        Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAtttackDto request);
        Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);
        Task<ServiceResponse<List<HighscoreDto>>> GetHighscore();
    }
}