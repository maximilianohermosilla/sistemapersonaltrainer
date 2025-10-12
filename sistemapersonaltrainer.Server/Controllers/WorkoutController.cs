using Microsoft.AspNetCore.Mvc;
using sistemapersonaltrainer.Server.DTOs;
using sistemapersonaltrainer.Server.Responses.Interfaces;

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
        public async Task<ActionResult<WorkoutReadDTO>> Create(WorkoutCreateDTO pWorkout)
        {
            try
            {
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

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<WorkoutReadDTO>>> GetAll()
        {
            try
            {
                var vWorkouts = await vGblService.GetAll();

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
