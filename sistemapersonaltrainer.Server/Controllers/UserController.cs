using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sistemapersonaltrainer.Server.DTOs;
using sistemapersonaltrainer.Server.Models;
using sistemapersonaltrainer.Server.Responses.Interfaces;

namespace sistemapersonaltrainer.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService vGblService;

        public UserController(IUserService pService)
        {
            vGblService = pService;
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<UserReadDTO>> Create(UserCreateDTO pUser)
        {
            try
            {
                var vUser = await vGblService.Create(pUser);

                if (vUser == null)
                {
                    return NotFound(new ResponseMessage() { Message = "Ocurrió un error al crear el Usuario", Success = false });
                }

                return Created("", vUser);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<UserReadDTO>> Login([FromBody] UserLoginDTO pUserLogin)
        {
            try
            {
                var vUser = await vGblService.GetByUserNamePassword(pUserLogin.UserName, pUserLogin.Password);

                if (vUser == null)
                {
                    return NotFound(new UserLoginReadDTO() { Mensaje = "Credenciales incorrectas" });
                }

                return Ok(new UserLoginReadDTO() { Mensaje = "Usuario registrado correctamente", Token = vUser.Token });
            }
            catch (Exception ex)
            {
                return BadRequest(new UserLoginReadDTO() { Mensaje = ex.Message });
            }
        }
    }
}
