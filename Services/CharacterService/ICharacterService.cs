using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.DTOs;

namespace dotnet.Services.CharacterService
{
    public interface ICharacterService
    {
    Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
    Task<ServiceResponse<GetCharacterDto>> GetCharacterbyId(int id);
    Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
    Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
    Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
    Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}