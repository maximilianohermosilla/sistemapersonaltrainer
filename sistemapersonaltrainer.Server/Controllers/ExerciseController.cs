using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sistemapersonaltrainer.Server.DTOs;
using sistemapersonaltrainer.Server.Responses.Interfaces;

namespace sistemapersonaltrainer.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly IExerciseService vGblService;

        public ExerciseController(IExerciseService pService)
        {
            vGblService = pService;
        }

        [HttpPost]
        public async Task<ActionResult<ExerciseReadDTO>> Create(ExerciseCreateDTO pExercise)
        {
            try
            {
                var vExercise = await vGblService.Create(pExercise);

                if (vExercise == null)
                {
                    return NotFound(new ResponseMessage() { Message = "Ocurrió un error al crear el Ejercicio", Success = false });
                }

                return Created("Ejercicio creado exitosamente", vExercise);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message, Success = false });
            }
        }

        [HttpPut]
        public async Task<ActionResult<ExerciseReadDTO>> Update(ExerciseCreateDTO pExercise)
        {
            try
            {
                var vExercise = await vGblService.Update(pExercise);

                if(vExercise == null)
                {
                    return NotFound(new ResponseMessage() { Message = "Ocurrió un error al actualizar el Ejercicio", Success = false });
                }

                return Created("Ejercicio actualizado exitosamente", vExercise);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message, Success = false });
            }
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<ExerciseReadDTO>>> GetAll()
        {
            try
            {
                var vExercises = await vGblService.GetAll();

                if (vExercises == null)
                {
                    return NotFound(new ResponseMessage() { Message = "Ocurrió un error al obtener los Ejercicios", Success = false });
                }

                return Ok(vExercises);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message, Success = false });
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ExerciseReadDTO>> GetById(int id)
        {
            try
            {
                var vExercise = await vGblService.GetById(id);

                if (vExercise == null)
                {
                    return NotFound(new ResponseMessage() { Message = "Ejercicio no encontrado" , Success = false });
                }

                return Ok(vExercise);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message, Success = false });
            }
        }
    }
}
