using sistemapersonaltrainer.Server.DTOs;

namespace sistemapersonaltrainer.Server.Responses.Interfaces
{
    public interface IWorkoutService
    {
        Task<WorkoutReadDTO?> Create(WorkoutCreateDTO pWorkout);
        Task<IEnumerable<WorkoutReadDTO>> GetAll();
        Task<WorkoutReadDTO> Update(WorkoutCreateDTO pParameter);
        Task<WorkoutReadDTO?> GetById(int pId);
    }
}
