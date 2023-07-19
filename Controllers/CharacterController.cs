using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
         private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
           {
                _characterService = characterService;
           }


        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get(){
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetCharacter(int id){
            return Ok(await _characterService.GetCharacterbyId(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacter(AddCharacterDto character){
            return Ok(await _characterService.AddCharacter(character));
        }


        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> UpdateCharacter(UpdateCharacterDto updatedCharacter){
            return Ok(await _characterService.UpdateCharacter(updatedCharacter));
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> DeleteCharacter(int id){
            return Ok(await _characterService.DeleteCharacter(id));
        }
    }
}