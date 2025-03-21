using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.Data;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthCntroller : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthCntroller(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await _authRepo.Register(
                new User{Username = request.Username}, request.Password
            );

            if(!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<ServiceResponse<int>>> Login(UserLoginDto request)
        {
            var response = await _authRepo.Login(request.Username, request.Password);

            if(!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

    }
}