using System.ComponentModel.DataAnnotations;

namespace sistemapersonaltrainer.Server.Models
{
    public class Exercise
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? UrlShortVideo { get; set; } = null;
        public string? UrlLongVideo { get; set; } = null;
        public int? DifficultyLevelId { get; set; } = null;
        public int? MuscleGroupId { get; set; } = null;
        public int? PrimeMoverMuscleId { get; set; } = null;
        public int? SecondaryMoverMuscleId { get; set; } = null;
        public int? TertiaryMoverMuscleId { get; set; } = null;
        public int? PrimaryEquipmentId { get; set; } = null;
        public int? PrimaryItems { get; set; } = null;
        public int? SecondaryEquipmentId { get; set; } = null;
        public int? SecondaryItems { get; set; } = null;
        public int? PostureId { get; set; } = null;
        public int? ExerciseArmTypeId { get; set; } = null;
        public int? ExerciseArmModeId { get; set; } = null;
        public int? GripId { get; set; } = null;
        public int? LoadPositionEndId { get; set; } = null;
        public int? ExerciseLegModeId { get; set; } = null;
        public int? FootElevationId { get; set; } = null;
        public int? CombinationExerciseId { get; set; } = null;
        public int? PrimaryPatternId { get; set; } = null;
        public int? SecondaryPatternId { get; set; } = null;
        public int? TertiaryPatternId { get; set; } = null;
        public int? PrimaryPlaneOfMotionId { get; set; } = null;
        public int? SecondaryPlaneOfMotionId { get; set; } = null;
        public int? TertiaryPlaneOfMotionId { get; set; } = null;
        public int? BodyRegionId { get; set; } = null;
        public int? ForceTypeId { get; set; } = null;
        public int? MechanicId { get; set; } = null;
        public int? LateralityId { get; set; } = null;
        public int? ExerciseClassificationId { get; set; } = null;

        public MuscleGroup? MuscleGroup { get; set; } = null;
        public DifficultyLevel? DifficultyLevel { get; set; } = null;
        public Muscle? PrimeMoverMuscle { get; set; } = null;
        public Muscle? SecondaryMoverMuscle { get; set; } = null;
        public Muscle? TertiaryMoverMuscle { get; set; } = null;
        public Equipment? PrimaryEquipment { get; set; } = null;
        public Equipment? SecondaryEquipment { get; set; } = null;
        public Posture? Posture { get; set; } = null;
        public ExerciseArmType? ExerciseArmType { get; set; } = null;
        public ExerciseMode? ExerciseArmMode { get; set; } = null;
        public Grip? Grip { get; set; } = null;
        public LoadPositionEnd? LoadPositionEnd { get; set; } = null;
        public ExerciseMode? ExerciseLegMode { get; set; } = null;
        public FootElevation? FootElevation { get; set; } = null;
        public CombinationExercise? CombinationExercise { get; set; } = null;
        public Pattern? PrimaryPattern { get; set; } = null;
        public Pattern? SecondaryPattern { get; set; } = null;
        public Pattern? TertiaryPattern { get; set; } = null;
        public PlaneOfMotion? PrimaryPlaneOfMotion { get; set; } = null;
        public PlaneOfMotion? SecondaryPlaneOfMotion { get; set; } = null;
        public PlaneOfMotion? TertiaryPlaneOfMotion { get; set; } = null;
        public BodyRegion? BodyRegion { get; set; } = null;
        public ForceType? ForceType { get; set; } = null;
        public Mechanic? Mechanic { get; set; } = null;
        public Laterality? Laterality { get; set; } = null;
        public ExerciseClassification? ExerciseClassification { get; set; } = null;
        public virtual ICollection<WorkoutActivityExercise> WorkoutActivityExercises { get; set; } = new List<WorkoutActivityExercise>();
    }
}
