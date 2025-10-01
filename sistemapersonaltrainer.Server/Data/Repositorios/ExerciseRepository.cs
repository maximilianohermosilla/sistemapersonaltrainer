using Microsoft.EntityFrameworkCore;
using sistemapersonaltrainer.Server.Data.Interfaces;
using sistemapersonaltrainer.Server.Models;

namespace sistemapersonaltrainer.Server.Data.Repositories
{
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly AppDbContext vGblContext;

        public ExerciseRepository(AppDbContext pContext)
        {
            vGblContext = pContext;
        }

        public bool SaveChanges()
        {
            return vGblContext.SaveChanges() > 0;
        }

        public Exercise Create(Exercise pExercise)
        {
            vGblContext.Exercises.Add(pExercise);
            vGblContext.SaveChanges();

            return pExercise;
        }

        public IEnumerable<Exercise> GetAll()
        {
            return vGblContext.Exercises
                .Include(e => e.DifficultyLevel)
                .Include(e => e.ExerciseClassification)
                .ToList();
        }

        public Exercise GetById(int pId)
        {
            return vGblContext.Exercises
                .Include(e => e.DifficultyLevel)
                .Include(e => e.MuscleGroup)
                .Include(e => e.PrimeMoverMuscle)
                .Include(e => e.SecondaryMoverMuscle)
                .Include(e => e.TertiaryMoverMuscle)
                .Include(e => e.PrimaryEquipment)
                .Include(e => e.SecondaryEquipment)
                .Include(e => e.Posture)
                .Include(e => e.ExerciseArmType)
                .Include(e => e.ExerciseArmMode)
                .Include(e => e.Grip)
                .Include(e => e.LoadPositionEnd)
                .Include(e => e.ExerciseLegMode)
                .Include(e => e.FootElevation)
                .Include(e => e.CombinationExercise)
                .Include(e => e.PrimaryPattern)
                .Include(e => e.SecondaryPattern)
                .Include(e => e.TertiaryPattern)
                .Include(e => e.PrimaryPlaneOfMotion)
                .Include(e => e.SecondaryPlaneOfMotion)
                .Include(e => e.TertiaryPlaneOfMotion)
                .Include(e => e.BodyRegion)
                .Include(e => e.ForceType)
                .Include(e => e.Mechanic)
                .Include(e => e.Laterality)
                .Include(e => e.ExerciseClassification)
                .FirstOrDefault(e => e.Id == pId)!;
        }
    }
}
