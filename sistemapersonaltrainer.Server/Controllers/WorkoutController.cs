using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sistemapersonaltrainer.Server.DTOs;
using sistemapersonaltrainer.Server.Models;
using sistemapersonaltrainer.Server.Responses.Interfaces;
using System.Security.Claims;

namespace sistemapersonaltrainer.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WorkoutController : ControllerBase
    {
        private readonly IWorkoutService vGblService;

        public WorkoutController(IWorkoutService pService)
        {
            vGblService = pService;
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<WorkoutReadDTO>> Create(WorkoutCreateDTO pWorkout)
        {
            try
            {
                string? vUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                pWorkout.UserId = Convert.ToInt32(vUserId);

                var vWorkout = await vGblService.Create(pWorkout);

                if (vWorkout == null)
                {
                    return NotFound(new ResponseMessage() { Message = "Ocurrió un error al crear el Ejercicio", Success = false });
                }

                return Created("Ejercicio creado exitosamente", vWorkout);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message, Success = false });
            }
        }

        [HttpPut]
        public async Task<ActionResult<WorkoutReadDTO>> Update(WorkoutCreateDTO pWorkout)
        {
            try
            {
                var vWorkout = await vGblService.Update(pWorkout);

                if(vWorkout == null)
                {
                    return NotFound(new ResponseMessage() { Message = "Ocurrió un error al actualizar el Ejercicio", Success = false });
                }

                return Created("Ejercicio actualizado exitosamente", vWorkout);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message, Success = false });
            }
        }

        [HttpGet("{customer}")]
        public async Task<ActionResult<IEnumerable<WorkoutReadDTO>>> GetAllByCustomer(string customer)
        {
            try
            {
                var vWorkouts = await vGblService.GetAllByCustomer(customer);

                if (vWorkouts == null)
                {
                    return NotFound(new ResponseMessage() { Message = "Ocurrió un error al obtener los Ejercicios", Success = false });
                }

                return Ok(vWorkouts);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message, Success = false });
            }
        }

        [HttpGet()]
        [Authorize]
        public async Task<ActionResult<IEnumerable<WorkoutReadDTO>>> GetAllByUser()
        {
            try
            {
                string? vUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var vWorkouts = await vGblService.GetAllByUser(Convert.ToInt32(vUserId));

                if (vWorkouts == null)
                {
                    return NotFound(new ResponseMessage() { Message = "Ocurrió un error al obtener los Ejercicios", Success = false });
                }

                return Ok(vWorkouts);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message, Success = false });
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WorkoutReadDTO>> GetById(int id)
        {
            try
            {
                var vWorkout = await vGblService.GetById(id);

                if (vWorkout == null)
                {
                    return NotFound(new ResponseMessage() { Message = "Ejercicio no encontrado" , Success = false });
                }

                return Ok(vWorkout);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message, Success = false });
            }
        }
    }
}
