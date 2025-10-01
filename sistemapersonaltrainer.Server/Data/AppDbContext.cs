using Microsoft.EntityFrameworkCore;
using sistemapersonaltrainer.Server.Models;

namespace sistemapersonaltrainer.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<BodyRegion> BodyRegions { get; set; }
        public DbSet<CombinationExercise> CombinationExercises { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Models.DifficultyLevel> DifficultyLevels { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseArmType> ExerciseArmTypes { get; set; }
        public DbSet<ExerciseClassification> ExerciseClassifications { get; set; }
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
                entity.HasOne(i => i.PrimeMoverMuscle).WithMany(i => i.PrimeMoverExercises).HasForeignKey(i => i.PrimeMoverMuscleId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.SecondaryMoverMuscle).WithMany(i => i.SecondaryMoverExercises).HasForeignKey(i => i.SecondaryMoverMuscleId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.TertiaryMoverMuscle).WithMany(i => i.TertiaryMoverExercises).HasForeignKey(i => i.TertiaryMoverMuscleId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.PrimaryEquipment).WithMany(i => i.PrimaryExercises).HasForeignKey(i => i.PrimaryEquipmentId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.SecondaryEquipment).WithMany(i => i.SecondaryExercises).HasForeignKey(i => i.SecondaryEquipmentId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.Posture).WithMany(i => i.Exercises).HasForeignKey(i => i.PostureId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.ExerciseArmType).WithMany(i => i.Exercises).HasForeignKey(i => i.ExerciseArmTypeId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.ExerciseArmMode).WithMany(i => i.ArmExercises).HasForeignKey(i => i.ExerciseArmModeId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.Grip).WithMany(i => i.Exercises).HasForeignKey(i => i.GripId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.LoadPositionEnd).WithMany(i => i.Exercises).HasForeignKey(i => i.LoadPositionEndId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.ExerciseLegMode).WithMany(i => i.LegExercises).HasForeignKey(i => i.ExerciseLegModeId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.FootElevation).WithMany(i => i.Exercises).HasForeignKey(i => i.FootElevationId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.CombinationExercise).WithMany(i => i.Exercises).HasForeignKey(i => i.CombinationExerciseId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.PrimaryPattern).WithMany(i => i.PrimaryExercises).HasForeignKey(i => i.PrimaryPatternId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.SecondaryPattern).WithMany(i => i.SecondaryExercises).HasForeignKey(i => i.SecondaryPatternId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.TertiaryPattern).WithMany(i => i.TertiaryExercises).HasForeignKey(i => i.TertiaryPatternId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.PrimaryPlaneOfMotion).WithMany(i => i.PrimaryExercises).HasForeignKey(i => i.PrimaryPlaneOfMotionId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.SecondaryPlaneOfMotion).WithMany(i => i.SecondaryExercises).HasForeignKey(i => i.SecondaryPlaneOfMotionId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.TertiaryPlaneOfMotion).WithMany(i => i.TertiaryExercises).HasForeignKey(i => i.TertiaryPlaneOfMotionId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.BodyRegion).WithMany(i => i.Exercises).HasForeignKey(i => i.BodyRegionId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.ForceType).WithMany(i => i.Exercises).HasForeignKey(i => i.ForceTypeId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.Mechanic).WithMany(i => i.Exercises).HasForeignKey(i => i.MechanicId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.Laterality).WithMany(i => i.Exercises).HasForeignKey(i => i.LateralityId).OnDelete(DeleteBehavior.NoAction);
                entity.HasMany(i => i.WorkoutActivityExercises).WithOne(i => i.Exercise).HasForeignKey(i => i.ExerciseId).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Workout>(entity =>
            {
                entity.HasOne(i => i.Customer).WithMany(i => i.Workouts).HasForeignKey(i => i.CustomerId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.User).WithMany(i => i.Workouts).HasForeignKey(i => i.UserId).OnDelete(DeleteBehavior.NoAction);
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

            modelBuilder.Entity<DifficultyLevel>().HasData(
                new DifficultyLevel { Id = 1, Name = "Advanced", Description = "Avanzado" },
                new DifficultyLevel { Id = 2, Name = "Beginner", Description = "Principiante" },
                new DifficultyLevel { Id = 3, Name = "Expert", Description = "Experto" },
                new DifficultyLevel { Id = 4, Name = "Grand Master", Description = "Gran Maestro" },
                new DifficultyLevel { Id = 5, Name = "Intermediate", Description = "Intermedio" },
                new DifficultyLevel { Id = 6, Name = "Legendary", Description = "Legendario" },
                new DifficultyLevel { Id = 7, Name = "Master", Description = "Maestro" },
                new DifficultyLevel { Id = 8, Name = "Novice", Description = "Novato" }
            );

            modelBuilder.Entity<MuscleGroup>().HasData(
                new MuscleGroup { Id = 1, Name = "Abdominals", Description = "Abdominales" },
                new MuscleGroup { Id = 2, Name = "Adductors", Description = "Aductores" },
                new MuscleGroup { Id = 3, Name = "Back", Description = "Espalda" },
                new MuscleGroup { Id = 4, Name = "Biceps", Description = "Biceps" },
                new MuscleGroup { Id = 5, Name = "Calves", Description = "Gemelos" },
                new MuscleGroup { Id = 6, Name = "Chest", Description = "Pecho" },
                new MuscleGroup { Id = 7, Name = "Forearms", Description = "Antebrazos" },
                new MuscleGroup { Id = 8, Name = "Glutes", Description = "Gluteos" },
                new MuscleGroup { Id = 9, Name = "Hamstrings", Description = "Isquiotibiales" },
                new MuscleGroup { Id = 10, Name = "Hip Flexors", Description = "Flexores de cadera" },
                new MuscleGroup { Id = 11, Name = "Quadriceps", Description = "Quadriceps" },
                new MuscleGroup { Id = 12, Name = "Shins", Description = "Espinillas" },
                new MuscleGroup { Id = 13, Name = "Shoulders", Description = "Hombros" },
                new MuscleGroup { Id = 14, Name = "Trapezius", Description = "Trapecios" },
                new MuscleGroup { Id = 15, Name = "Triceps", Description = "Triceps" }
            );

            modelBuilder.Entity<Muscle>().HasData(
                new Muscle { Id = 1, Name = "Adductor Magnus", Description = "Aductor Mayor" },
                new Muscle { Id = 2, Name = "Anterior Deltoids", Description = "Deltoides Anterior" },
                new Muscle { Id = 3, Name = "Biceps Brachii", Description = "Bíceps Braquial" },
                new Muscle { Id = 4, Name = "Biceps Femoris", Description = "Bíceps Femoral" },
                new Muscle { Id = 5, Name = "Brachialis", Description = "Braquial" },
                new Muscle { Id = 6, Name = "Brachioradialis", Description = "Braquiorradial" },
                new Muscle { Id = 7, Name = "Erector Spinae", Description = "Erector de la Columna" },
                new Muscle { Id = 8, Name = "Extensor Hallucis Longus", Description = "Extensor Largo del Dedo Gordo" },
                new Muscle { Id = 9, Name = "Flexor Carpi Radialis", Description = "Flexor Radial del Carpo" },
                new Muscle { Id = 10, Name = "Gastrocnemius", Description = "Gastrocnemio" },
                new Muscle { Id = 11, Name = "Gluteus Maximus", Description = "Glúteo Mayor" },
                new Muscle { Id = 12, Name = "Gluteus Medius", Description = "Glúteo Medio" },
                new Muscle { Id = 13, Name = "Gluteus Minimus", Description = "Glúteo Menor" },
                new Muscle { Id = 14, Name = "Iliopsoas", Description = "Psoas Iliaco" },
                new Muscle { Id = 15, Name = "Latissimus Dorsi", Description = "Dorsal Ancho" },
                new Muscle { Id = 16, Name = "Obliques", Description = "Oblicuos" },
                new Muscle { Id = 17, Name = "Pectoralis Major", Description = "Pectoral Mayor" },
                new Muscle { Id = 18, Name = "Posterior Deltoids", Description = "Deltoides Posterior" },
                new Muscle { Id = 19, Name = "Quadriceps Femoris", Description = "Cuádriceps Femoral" },
                new Muscle { Id = 20, Name = "Rectus Abdominis", Description = "Recto Abdominal" },
                new Muscle { Id = 21, Name = "Rectus Femoris", Description = "Recto Femoral" },
                new Muscle { Id = 22, Name = "Rhomboids", Description = "Romboides" },
                new Muscle { Id = 23, Name = "Serratus Anterior", Description = "Serrato Anterior" },
                new Muscle { Id = 24, Name = "Soleus", Description = "Sóleo" },
                new Muscle { Id = 25, Name = "Tensor Fasciae Latae", Description = "Tensor de la Fascia Lata" },
                new Muscle { Id = 26, Name = "Teres Major", Description = "Redondo Mayor" },
                new Muscle { Id = 27, Name = "Teres Minor", Description = "Redondo Menor" },
                new Muscle { Id = 28, Name = "Tibialis Anterior", Description = "Tibial Anterior" },
                new Muscle { Id = 29, Name = "Tibialis Posterior", Description = "Tibial Posterior" },
                new Muscle { Id = 30, Name = "Transverse Abdominis", Description = "Transverso del Abdomen" },
                new Muscle { Id = 31, Name = "Trapezius", Description = "Trapecio" },
                new Muscle { Id = 32, Name = "Triceps Brachii", Description = "Tríceps Braquial" },
                new Muscle { Id = 33, Name = "Upper Trapezius", Description = "Trapecio Superior" },
                new Muscle { Id = 34, Name = "Lateral Deltoids", Description = "Deltoides Lateral" },
                new Muscle { Id = 35, Name = "Anconeus", Description = "Ancóneo" },
                new Muscle { Id = 36, Name = "Infraspinatus", Description = "Infraespinoso" },
                new Muscle { Id = 37, Name = "Levator Scapulae", Description = "Elevador de la Escápula" },
                new Muscle { Id = 38, Name = "Extensor Digitorum Longus", Description = "Extensor Largo de los Dedos" },
                new Muscle { Id = 39, Name = "Supraspinatus", Description = "Supraespinoso" },
                new Muscle { Id = 40, Name = "Medial Deltoids", Description = "Deltoides Medial" },
                new Muscle { Id = 41, Name = "Subscapularis", Description = "Subescapular" },
                new Muscle { Id = 42, Name = "Vastus Mediais", Description = "Vasto Medial" }
            );

            modelBuilder.Entity<Equipment>().HasData(
                new Equipment { Id = 1, Name = "Ab Wheel", Description = null },
                new Equipment { Id = 2, Name = "Barbell", Description = null },
                new Equipment { Id = 3, Name = "Battle Ropes", Description = null },
                new Equipment { Id = 4, Name = "Bench (Decline)", Description = null },
                new Equipment { Id = 5, Name = "Bench (Flat)", Description = null },
                new Equipment { Id = 6, Name = "Bench (Incline)", Description = null },
                new Equipment { Id = 7, Name = "Bodyweight", Description = null },
                new Equipment { Id = 8, Name = "Bulgarian Bag", Description = null },
                new Equipment { Id = 9, Name = "Cable", Description = null },
                new Equipment { Id = 10, Name = "Climbing Rope", Description = null },
                new Equipment { Id = 11, Name = "Clubbell", Description = null },
                new Equipment { Id = 12, Name = "Dumbbell", Description = null },
                new Equipment { Id = 13, Name = "EZ Bar", Description = null },
                new Equipment { Id = 14, Name = "Gravity Boots", Description = null },
                new Equipment { Id = 15, Name = "Gymnastic Rings", Description = null },
                new Equipment { Id = 16, Name = "Heavy Sandbag", Description = null },
                new Equipment { Id = 17, Name = "Indian Club", Description = null },
                new Equipment { Id = 18, Name = "Kettlebell", Description = null },
                new Equipment { Id = 19, Name = "Landmine", Description = null },
                new Equipment { Id = 20, Name = "Macebell", Description = null },
                new Equipment { Id = 21, Name = "Medicine Ball", Description = null },
                new Equipment { Id = 22, Name = "Miniband", Description = null },
                new Equipment { Id = 23, Name = "Parallette Bars", Description = null },
                new Equipment { Id = 24, Name = "Plyo Box", Description = null },
                new Equipment { Id = 25, Name = "Pull Up Bar", Description = null },
                new Equipment { Id = 26, Name = "Resistance Band", Description = null },
                new Equipment { Id = 27, Name = "Sandbag", Description = null },
                new Equipment { Id = 28, Name = "Slam Ball", Description = null },
                new Equipment { Id = 29, Name = "Slant Board", Description = null },
                new Equipment { Id = 30, Name = "Sled", Description = null },
                new Equipment { Id = 31, Name = "Sledge Hammer", Description = null },
                new Equipment { Id = 32, Name = "Sliders", Description = null },
                new Equipment { Id = 33, Name = "Stability Ball", Description = null },
                new Equipment { Id = 34, Name = "Superband", Description = null },
                new Equipment { Id = 35, Name = "Suspension Trainer", Description = null },
                new Equipment { Id = 36, Name = "Tire", Description = null },
                new Equipment { Id = 37, Name = "Trap Bar", Description = null },
                new Equipment { Id = 38, Name = "Wall Ball", Description = null },
                new Equipment { Id = 39, Name = "Weight Plate", Description = null },
                new Equipment { Id = 40, Name = "None", Description = null }
            );

            modelBuilder.Entity<Posture>().HasData(
                new Posture { Id = 1, Name = "90/90 Seated", Description = "90/90 Sentado" },
                new Posture { Id = 2, Name = "Bridge", Description = "Puente" },
                new Posture { Id = 3, Name = "Half Kneeling", Description = "Media rodilla" },
                new Posture { Id = 4, Name = "Hanging", Description = "Colgado" },
                new Posture { Id = 5, Name = "Horse Stance", Description = "Postura del jinete" },
                new Posture { Id = 6, Name = "Inverted", Description = "Invertida" },
                new Posture { Id = 7, Name = "Isometric Split Squat", Description = "Estocada isométrica" },
                new Posture { Id = 8, Name = "Knee Hover Quadruped", Description = "Plancha a cuatro patas con rodilla elevada" },
                new Posture { Id = 9, Name = "Knee Over Toe Split Squat", Description = "Estocada con rodilla sobre el pie" },
                new Posture { Id = 10, Name = "Knee Supported", Description = "Apoyado de rodillas" },
                new Posture { Id = 11, Name = "Kneeling", Description = "Arrodillado" },
                new Posture { Id = 12, Name = "L Sit", Description = "Posición L sentado" },
                new Posture { Id = 13, Name = "March", Description = "Marcha" },
                new Posture { Id = 14, Name = "Other", Description = "Otra" },
                new Posture { Id = 15, Name = "Prone", Description = "Prono (boca abajo)" },
                new Posture { Id = 16, Name = "Quadruped", Description = "A cuatro patas" },
                new Posture { Id = 17, Name = "Running", Description = "Carrera" },
                new Posture { Id = 18, Name = "Seated", Description = "Sentado" },
                new Posture { Id = 19, Name = "Seated Floor", Description = "Sentado en el suelo" },
                new Posture { Id = 20, Name = "Shin Box Seated", Description = "Sentado en caja de espinillas" },
                new Posture { Id = 21, Name = "Side Lying", Description = "De lado" },
                new Posture { Id = 22, Name = "Side Plank", Description = "Plancha lateral" },
                new Posture { Id = 23, Name = "Single Leg Bridge", Description = "Puente a una pierna" },
                new Posture { Id = 24, Name = "Single Leg Standing", Description = "De pie a una pierna" },
                new Posture { Id = 25, Name = "Single Leg Standing Bent Knee", Description = "De pie a una pierna con rodilla flexionada" },
                new Posture { Id = 26, Name = "Single Leg Supported", Description = "Apoyado a una pierna" },
                new Posture { Id = 27, Name = "Split Squat", Description = "Estocada" },
                new Posture { Id = 28, Name = "Staggered Stance", Description = "Postura escalonada" },
                new Posture { Id = 29, Name = "Standing", Description = "De pie" },
                new Posture { Id = 30, Name = "Supine", Description = "Supino (boca arriba)" },
                new Posture { Id = 31, Name = "Tall Kneeling", Description = "De rodillas alto" },
                new Posture { Id = 32, Name = "Toe Balance", Description = "Equilibrio en la punta del pie" },
                new Posture { Id = 33, Name = "Tuck L Sit", Description = "Posición L sentado agrupado" },
                new Posture { Id = 34, Name = "V Sit Seated", Description = "Posición V sentado" },
                new Posture { Id = 35, Name = "Walking", Description = "Caminando" },
                new Posture { Id = 36, Name = "Wall Sit", Description = "Sentado en la pared" }
            );

            modelBuilder.Entity<ExerciseArmType>().HasData(
                new ExerciseArmType { Id = 1, Name = "Double Arm", Description = "Doble brazo" },
                new ExerciseArmType { Id = 2, Name = "No Arms", Description = "Sin brazos" },
                new ExerciseArmType { Id = 3, Name = "Single Arm", Description = "Un brazo" }
            );

            modelBuilder.Entity<ExerciseMode>().HasData(
                new ExerciseMode { Id = 1, Name = "Alternating", Description = "Alternando" },
                new ExerciseMode { Id = 2, Name = "Continuous", Description = "Continuo" }
            );

            modelBuilder.Entity<Grip>().HasData(
                new Grip { Id = 1, Name = "Bottoms Up", Description = "Con agarrón hacia arriba" },
                new Grip { Id = 2, Name = "Bottoms Up Horn Grip", Description = "Agarre de cuerno invertido" },
                new Grip { Id = 3, Name = "Crush Grip", Description = "Agarre de aplastamiento" },
                new Grip { Id = 4, Name = "False Grip", Description = "Agarre falso" },
                new Grip { Id = 5, Name = "Fingertip", Description = "Agarre con las yemas de los dedos" },
                new Grip { Id = 6, Name = "Flat Palm", Description = "Palma plana" },
                new Grip { Id = 7, Name = "Forearm", Description = "Agarre con el antebrazo" },
                new Grip { Id = 8, Name = "Goblet", Description = "Agarre de copa" },
                new Grip { Id = 9, Name = "Hand Assisted", Description = "Agarre con asistencia de la mano" },
                new Grip { Id = 10, Name = "Head Supported", Description = "Agarre con apoyo en la cabeza" },
                new Grip { Id = 11, Name = "Horn Grip", Description = "Agarre de cuerno" },
                new Grip { Id = 12, Name = "Mixed Grip", Description = "Agarre mixto" },
                new Grip { Id = 13, Name = "Neutral", Description = "Agarre neutral o de martillo" },
                new Grip { Id = 14, Name = "No Grip", Description = "Sin agarre" },
                new Grip { Id = 15, Name = "Other", Description = "Otro" },
                new Grip { Id = 16, Name = "Pronated", Description = "Agarre pronado (palmas hacia abajo)" },
                new Grip { Id = 17, Name = "Supinated", Description = "Agarre supinado (palmas hacia arriba)" },
                new Grip { Id = 18, Name = "Waiter Hold", Description = "Agarre de camarero" }
            );

            modelBuilder.Entity<LoadPositionEnd>().HasData(
                new LoadPositionEnd { Id = 1, Name = "Above Chest", Description = "Por encima del pecho" },
                new LoadPositionEnd { Id = 2, Name = "Back Rack", Description = "En rack trasero" },
                new LoadPositionEnd { Id = 3, Name = "Bear Hug", Description = "Abrazo de oso" },
                new LoadPositionEnd { Id = 4, Name = "Behind Back", Description = "A la espalda" },
                new LoadPositionEnd { Id = 5, Name = "Front Rack", Description = "En rack frontal" },
                new LoadPositionEnd { Id = 6, Name = "Hip Crease", Description = "En el pliegue de la cadera" },
                new LoadPositionEnd { Id = 7, Name = "Lateral", Description = "Lateral" },
                new LoadPositionEnd { Id = 8, Name = "Low Hold", Description = "Sostenido bajo" },
                new LoadPositionEnd { Id = 9, Name = "No Load", Description = "Sin carga" },
                new LoadPositionEnd { Id = 10, Name = "Order", Description = "Orden" },
                new LoadPositionEnd { Id = 11, Name = "Other", Description = "Otro" },
                new LoadPositionEnd { Id = 12, Name = "Overhead", Description = "Por encima de la cabeza" },
                new LoadPositionEnd { Id = 13, Name = "Shoulder", Description = "En el hombro" },
                new LoadPositionEnd { Id = 14, Name = "Suitcase", Description = "Como maletín" },
                new LoadPositionEnd { Id = 15, Name = "Zercher", Description = "Zercher" }
            );

            modelBuilder.Entity<FootElevation>().HasData(
                new FootElevation { Id = 1, Name = "Feet Elevated", Description = "Pies Elevados" },
                new FootElevation { Id = 2, Name = "Foot Elevated", Description = "Pie Elevado" },
                new FootElevation { Id = 3, Name = "Foot Elevated (Front)", Description = "Pie Elevado (Frontal)" },
                new FootElevation { Id = 4, Name = "Foot Elevated (Lateral)", Description = "Pie Elevado (Lateral)" },
                new FootElevation { Id = 5, Name = "Foot Elevated (Rear)", Description = "Pie Elevado (Trasero)" },
                new FootElevation { Id = 6, Name = "Foot Elevated (Side)", Description = "Pie Elevado (De costado)" },
                new FootElevation { Id = 7, Name = "Heels Elevated", Description = "Tacones elevados" },
                new FootElevation { Id = 8, Name = "No Elevation", Description = "Sin elevación" },
                new FootElevation { Id = 9, Name = "Toes Elevated", Description = "Dedos elevados" }
            );

            modelBuilder.Entity<CombinationExercise>().HasData(
                new CombinationExercise { Id = 1, Name = "Combo Exercise", Description = "Ejercicio Combinado" },
                new CombinationExercise { Id = 2, Name = "Single Exercise", Description = "Ejercicio Simple" }
            );

            modelBuilder.Entity<Pattern>().HasData(
                new Pattern { Id = 1, Name = "Ankle Dorsiflexion", Description = "Dorsiflexión de tobillo" },
                new Pattern { Id = 2, Name = "Ankle Plantar Flexion", Description = "Flexión plantar de tobillo" },
                new Pattern { Id = 3, Name = "Anti-Extension", Description = "Anti-extensión" },
                new Pattern { Id = 4, Name = "Anti-Flexion", Description = "Anti-flexión" },
                new Pattern { Id = 5, Name = "Anti-Lateral Flexion", Description = "Anti-flexión lateral" },
                new Pattern { Id = 6, Name = "Anti-Rotational", Description = "Anti-rotación" },
                new Pattern { Id = 7, Name = "Elbow Extension", Description = "Extensión de codo" },
                new Pattern { Id = 8, Name = "Elbow Flexion", Description = "Flexión de codo" },
                new Pattern { Id = 9, Name = "Hip Abduction", Description = "Abducción de cadera" },
                new Pattern { Id = 10, Name = "Hip Adduction", Description = "Aducción de cadera" },
                new Pattern { Id = 11, Name = "Hip Dominant", Description = "Dominante de cadera" },
                new Pattern { Id = 12, Name = "Hip Extension", Description = "Extensión de cadera" },
                new Pattern { Id = 13, Name = "Hip External Rotation", Description = "Rotación externa de cadera" },
                new Pattern { Id = 14, Name = "Hip Flexion", Description = "Flexión de cadera" },
                new Pattern { Id = 15, Name = "Hip Hinge", Description = "Bisagra de cadera" },
                new Pattern { Id = 16, Name = "Horizontal Adduction", Description = "Aducción horizontal" },
                new Pattern { Id = 17, Name = "Horizontal Pull", Description = "Tracción horizontal" },
                new Pattern { Id = 18, Name = "Horizontal Push", Description = "Empuje horizontal" },
                new Pattern { Id = 19, Name = "Isometric Hold", Description = "Sostén isométrico" },
                new Pattern { Id = 20, Name = "Knee Dominant", Description = "Dominante de rodilla" },
                new Pattern { Id = 21, Name = "Lateral Flexion", Description = "Flexión lateral" },
                new Pattern { Id = 22, Name = "Lateral Locomotion", Description = "Desplazamiento lateral" },
                new Pattern { Id = 23, Name = "Loaded Carry", Description = "Carga en desplazamiento" },
                new Pattern { Id = 24, Name = "Locomotion", Description = "Desplazamiento" },
                new Pattern { Id = 25, Name = "Other", Description = "Otro" },
                new Pattern { Id = 26, Name = "Rotational", Description = "Rotacional" },
                new Pattern { Id = 27, Name = "Scapular Elevation", Description = "Elevación escapular" },
                new Pattern { Id = 28, Name = "Shoulder Abduction", Description = "Abducción de hombro" },
                new Pattern { Id = 29, Name = "Shoulder External Rotation", Description = "Rotación externa de hombro" },
                new Pattern { Id = 30, Name = "Shoulder Flexion", Description = "Flexión de hombro" },
                new Pattern { Id = 31, Name = "Shoulder Internal Rotation", Description = "Rotación interna de hombro" },
                new Pattern { Id = 32, Name = "Shoulder Scapular Plane Elevation", Description = "Elevación en el plano escapular del hombro" },
                new Pattern { Id = 33, Name = "Spinal Extension", Description = "Extensión espinal" },
                new Pattern { Id = 34, Name = "Spinal Flexion", Description = "Flexión espinal" },
                new Pattern { Id = 35, Name = "Spinal Rotational", Description = "Rotación espinal" },
                new Pattern { Id = 36, Name = "Unsorted*", Description = "Sin clasificar*" },
                new Pattern { Id = 37, Name = "Vertical Pull", Description = "Tracción vertical" },
                new Pattern { Id = 38, Name = "Vertical Push", Description = "Empuje vertical" },
                new Pattern { Id = 39, Name = "Wrist Extension", Description = "Extensión de muñeca" },
                new Pattern { Id = 40, Name = "Wrist Flexion", Description = "Flexión de muñeca" },
                new Pattern { Id = 41, Name = "Hip Internal Rotation", Description = "Rotación interna de cadera" }
            );

            modelBuilder.Entity<PlaneOfMotion>().HasData(
                new PlaneOfMotion { Id = 1, Name = "Frontal Plane", Description = "Plano Frontal" },
                new PlaneOfMotion { Id = 2, Name = "Sagittal Plane", Description = "Plano Sagital" },
                new PlaneOfMotion { Id = 3, Name = "Transverse Plane", Description = "Plano Transversal" }
            );

            modelBuilder.Entity<BodyRegion>().HasData(
                new BodyRegion { Id = 1, Name = "Core", Description = "Centro" },
                new BodyRegion { Id = 2, Name = "Full Body", Description = "Cuerpo Completo" },
                new BodyRegion { Id = 3, Name = "Lower Body", Description = "Cuerpo Inferior" },
                new BodyRegion { Id = 4, Name = "Upper Body", Description = "Cuerpo Superior" }
            );

            modelBuilder.Entity<ForceType>().HasData(
                new ForceType { Id = 1, Name = "Other", Description = "Otro" },
                new ForceType { Id = 2, Name = "Pull", Description = "Tirar" },
                new ForceType { Id = 3, Name = "Push", Description = "Empujar" },
                new ForceType { Id = 4, Name = "Push & Pull", Description = "Empujar y Tirar" },
                new ForceType { Id = 5, Name = "Unsorted*", Description = "Sin clasificar*" }
            );

            modelBuilder.Entity<Mechanic>().HasData(
                new Mechanic { Id = 1, Name = "Compound", Description = "Compuesto" },
                new Mechanic { Id = 2, Name = "Isolation", Description = "Aislamiento" },
                new Mechanic { Id = 3, Name = "Pull", Description = "Tirar" }
            );

            modelBuilder.Entity<Laterality>().HasData(
                new Laterality { Id = 1, Name = "Bilateral", Description = "Bilateral" },
                new Laterality { Id = 2, Name = "Contralateral", Description = "Contralateral" },
                new Laterality { Id = 3, Name = "Ipsilateral", Description = "Ipsolateral" },
                new Laterality { Id = 4, Name = "Unilateral", Description = "Unilateral" }
            );

            modelBuilder.Entity<ExerciseClassification>().HasData(
                new ExerciseClassification { Id = 1, Name = "Animal Flow", Description = "Flujo animal" },
                new ExerciseClassification { Id = 2, Name = "Balance", Description = "Equilibrio" },
                new ExerciseClassification { Id = 3, Name = "Ballistics", Description = "Ejercicios balísticos" },
                new ExerciseClassification { Id = 4, Name = "Bodybuilding", Description = "Culturismo" },
                new ExerciseClassification { Id = 5, Name = "Calisthenics", Description = "Calistenia" },
                new ExerciseClassification { Id = 6, Name = "Grinds", Description = "Movimientos de fuerza sostenida" },
                new ExerciseClassification { Id = 7, Name = "Mobility", Description = "Movilidad" },
                new ExerciseClassification { Id = 8, Name = "Olympic Weightlifting", Description = "Halterofilia" },
                new ExerciseClassification { Id = 9, Name = "Olympic Weightlifting ", Description = "Halterofilia" },
                new ExerciseClassification { Id = 10, Name = "Plyometric", Description = "Pliometría" },
                new ExerciseClassification { Id = 11, Name = "Postural", Description = "Postural" },
                new ExerciseClassification { Id = 12, Name = "Powerlifting", Description = "Levantamiento de potencia" },
                new ExerciseClassification { Id = 13, Name = "Unsorted*", Description = "Sin clasificar" }
            );

            #endregion
        }
    }
}
