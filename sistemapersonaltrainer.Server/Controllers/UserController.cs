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
    }
}
