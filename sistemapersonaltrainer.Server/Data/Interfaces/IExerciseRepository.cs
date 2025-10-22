using sistemapersonaltrainer.Server.Models;

namespace sistemapersonaltrainer.Server.Data.Interfaces
{
    public interface IExerciseRepository
    {
        bool SaveChanges();
        IEnumerable<Exercise> GetAll();
        Exercise GetById(int pId);
        Exercise Create(Exercise pExercise);
        bool Delete(int pId);
    }
}
