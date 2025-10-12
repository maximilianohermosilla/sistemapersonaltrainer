using sistemapersonaltrainer.Server.Models;

namespace sistemapersonaltrainer.Server.Data.Interfaces
{
    public interface IWorkoutRepository
    {
        bool SaveChanges();
        IEnumerable<Workout> GetAll();
        Workout GetById(int pId);
        Workout Create(Workout pWorkout);
    }
}
