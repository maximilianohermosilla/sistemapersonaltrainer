using Microsoft.EntityFrameworkCore;
using sistemapersonaltrainer.Server.Data.Interfaces;
using sistemapersonaltrainer.Server.Models;

namespace sistemapersonaltrainer.Server.Data.Repositories
{
    public class WorkoutRepository : IWorkoutRepository
    {
        private readonly AppDbContext vGblContext;

        public WorkoutRepository(AppDbContext pContext)
        {
            vGblContext = pContext;
        }

        public bool SaveChanges()
        {
            return vGblContext.SaveChanges() > 0;
        }

        public Workout Create(Workout WEorkout)
        {
            vGblContext.Workouts.Add(WEorkout);
            vGblContext.SaveChanges();

            return WEorkout;
        }

        public IEnumerable<Workout> GetAll()
        {
            return vGblContext.Workouts
                .Include(e => e.WorkoutActivities)
                .ThenInclude(e => e.WorkoutActivityExercises)
                .Include(e => e.Customer)
                .Include(e => e.User)
                .ToList();
        }

        public Workout GetById(int pId)
        {
            return vGblContext.Workouts
                 .Include(e => e.WorkoutActivities)
                .ThenInclude(e => e.WorkoutActivityExercises)
                .Include(e => e.Customer)
                .Include(e => e.User)
                .FirstOrDefault(e => e.Id == pId)!;
        }
    }
}
