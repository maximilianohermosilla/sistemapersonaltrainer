using sistemapersonaltrainer.Server.Models;

namespace sistemapersonaltrainer.Server.Data.Interfaces
{
    public interface IWorkoutRepository
    {
        bool SaveChanges();
        IEnumerable<Workout> GetAll();
        IEnumerable<Workout> GetAllByUser(int userId);
        IEnumerable<Workout> GetAllByCustomer(string customer);
        Workout GetById(int pId);
        Workout Create(Workout pWorkout);
    }
}
