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
        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            Characters.Add(newCharacter);
            return Characters;
        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return Characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            return Characters.FirstOrDefault(c => c.Id == id);

        }
    }
}