using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using udemy1.Services.CharacterService;
using udemy1.Dtos.Character;

namespace udemy1.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
        Task<ServiceResponse<List<GetCharacterDto>>> UpdateCharacter (UpdateCharacterDto updateCharacter);
    }
}