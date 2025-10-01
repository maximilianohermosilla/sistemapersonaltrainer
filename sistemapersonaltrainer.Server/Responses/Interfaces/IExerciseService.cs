using sistemapersonaltrainer.Server.DTOs;

namespace sistemapersonaltrainer.Server.Responses.Interfaces
{
    public interface IExerciseService
    {
        Task<ExerciseReadDTO?> Create(ExerciseCreateDTO pExercise);
        Task<IEnumerable<ExerciseReadDTO>> GetAll();
        Task<ExerciseReadDTO> Update(ExerciseCreateDTO pParameter);
        Task<ExerciseReadDTO?> GetById(int pId);
    }
}
