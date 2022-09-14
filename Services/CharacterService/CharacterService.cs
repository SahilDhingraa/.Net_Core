using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace udemy1.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> Characters = new List<Character>{
            new Character(),
            new Character{Id = 1, Name = "Sam", HitPoints = 10000}
        };
        public List<Character> AddCharacter(Character newCharacter)
        {
            Characters.Add(newCharacter);
            return Characters;
        }

        public List<Character> GetAllCharacters()
        {
            return Characters;
        }

        public Character GetCharacterById(int id)
        {
            return Characters.FirstOrDefault(c => c.Id == id);

        }
    }
}