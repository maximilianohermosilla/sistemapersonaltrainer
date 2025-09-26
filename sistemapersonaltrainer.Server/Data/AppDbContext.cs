using Microsoft.EntityFrameworkCore;
using sistemapersonaltrainer.Server.Models;

namespace sistemapersonaltrainer.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<BodyRegion> BodyRegions { get; set; }
        public DbSet<CombinationExcercise> CombinationExcercises { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DifficultyLevel> DifficultyLevels { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseArmType> ExerciseArmTypes { get; set; }
        public DbSet<ExerciseClassification> ExcerciseCalifications { get; set; }
        public DbSet<ExerciseMode> ExerciseModes { get; set; }
        public DbSet<FootElevation> FootElevations { get; set; }
        public DbSet<ForceType> ForceTypes { get; set; }
        public DbSet<Grip> Grips { get; set; }
        public DbSet<Laterality> Lateralities { get; set; }
        public DbSet<LoadPositionEnd> LoadPositionEnds { get; set; }
        public DbSet<Mechanic> Mechanics { get; set; }
        public DbSet<Muscle> Muscles { get; set; }
        public DbSet<MuscleGroup> MuscleGroups { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<Pattern> Patterns { get; set; }
        public DbSet<PlaneOfMotion> PlaneOfMotions { get; set; }
        public DbSet<Posture> Postures { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<WorkoutActivity> WorkoutActivities { get; set; }
        public DbSet<WorkoutActivityExercise> WorkoutActivityExercises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercise>(entity =>
            {
                entity.HasOne(i => i.MuscleGroup).WithMany(i => i.Exercises).HasForeignKey(i => i.MuscleGroupId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.DifficultyLevel).WithMany(i => i.Exercises).HasForeignKey(i => i.DifficultyLevelId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.PrimeMoverMuscle).WithMany(i => i.Exercises).HasForeignKey(i => i.PrimeMoverMuscleId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.SecondaryMoverMuscle).WithMany(i => i.Exercises).HasForeignKey(i => i.SecondaryMoverMuscleId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.TertiaryMoverMuscle).WithMany(i => i.Exercises).HasForeignKey(i => i.TertiaryMoverMuscleId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.PrimaryEquipment).WithMany(i => i.Exercises).HasForeignKey(i => i.PrimaryEquipmentId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.SecondaryEquipment).WithMany(i => i.Exercises).HasForeignKey(i => i.SecondaryEquipmentId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.Posture).WithMany(i => i.Exercises).HasForeignKey(i => i.PostureId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.ExerciseArmType).WithMany(i => i.Exercises).HasForeignKey(i => i.ExerciseArmTypeId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.ExerciseArmMode).WithMany(i => i.Exercises).HasForeignKey(i => i.ExerciseArmModeId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.Grip).WithMany(i => i.Exercises).HasForeignKey(i => i.GripId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.LoadPositionEnd).WithMany(i => i.Exercises).HasForeignKey(i => i.LoadPositionEndId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.ExerciseLegMode).WithMany(i => i.Exercises).HasForeignKey(i => i.ExerciseLegModeId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.FootElevation).WithMany(i => i.Exercises).HasForeignKey(i => i.FootElevationId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.CombinationExcercise).WithMany(i => i.Exercises).HasForeignKey(i => i.CombinationExcerciseId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.PrimaryPattern).WithMany(i => i.Exercises).HasForeignKey(i => i.PrimaryPatternId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.SecondaryPattern).WithMany(i => i.Exercises).HasForeignKey(i => i.SecondaryPatternId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.TertiaryPattern).WithMany(i => i.Exercises).HasForeignKey(i => i.TertiaryPatternId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.PrimaryPlaneOfMotion).WithMany(i => i.Exercises).HasForeignKey(i => i.PrimaryPlaneOfMotionId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.SecondaryPlaneOfMotion).WithMany(i => i.Exercises).HasForeignKey(i => i.SecondaryPlaneOfMotionId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.TertiaryPlaneOfMotion).WithMany(i => i.Exercises).HasForeignKey(i => i.TertiaryPlaneOfMotionId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.BodyRegion).WithMany(i => i.Exercises).HasForeignKey(i => i.BodyRegionId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.ForceType).WithMany(i => i.Exercises).HasForeignKey(i => i.ForceTypeId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.Mechanic).WithMany(i => i.Exercises).HasForeignKey(i => i.MechanicId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.Laterality).WithMany(i => i.Exercises).HasForeignKey(i => i.LateralityId).OnDelete(DeleteBehavior.NoAction);
                entity.HasMany(i => i.WorkoutActivityExercises).WithOne(i => i.Exercise).HasForeignKey(i => i.ExerciseId).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Workout>(entity =>
            {
                entity.HasOne(i => i.Customer).WithMany(i => i.Workouts).HasForeignKey(i => i.CustomerId).OnDelete(DeleteBehavior.NoAction);
                entity.HasMany(i => i.WorkoutActivities).WithOne(i => i.Workout).HasForeignKey(i => i.WorkoutId).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<WorkoutActivityExercise>(entity =>
            {
                entity.HasOne(i => i.WorkoutActivity).WithMany(i => i.WorkoutActivityExercises).HasForeignKey(i => i.WorkoutActivityId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.Exercise).WithMany(i => i.WorkoutActivityExercises).HasForeignKey(i => i.ExerciseId).OnDelete(DeleteBehavior.NoAction);
            });


            #region HasData

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Administrador",
                    LastName = "Sistemas",
                    Email = "maximiliano_hermosilla@hotmail.com",
                    UserName = "admin",
                    Password = "U+QpQHyCKuYC78AAH05KwA==",
                    CreatedAt = new DateTime(2025, 09, 01, 00, 0, 0, DateTimeKind.Utc),
                    Enabled = true
                },
                new User
                {
                    Id = 2,
                    Name = "Isaias",
                    LastName = "Luque",
                    Email = "isaias.luque@mayidev.com",
                    UserName = "isaiasLuque",
                    Password = "U+QpQHyCKuYC78AAH05KwA==",
                    CreatedAt = new DateTime(2025, 09, 01, 00, 0, 0, DateTimeKind.Utc),
                    Enabled = true
                }
            );
            #endregion
        }
    }
}
