using udemy1.Dtos.Skill;
using udemy1.Dtos.Weapon;

namespace udemy1.Dtos.Character
{
    public class GetCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Nigga";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Banda;
        public GetWeaponDto Weapon { get; set; }
        public List<GetSkillDto> Skills { get; set; }
        public int Fghts { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }
    }
}