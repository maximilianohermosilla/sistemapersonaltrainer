namespace sistemapersonaltrainer.Server.DTOs
{
    public class ExerciseReadDTO
    {
        public int Id { get; set; }
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

        public MuscleGroupReadDTO? MuscleGroup { get; set; } = null;
        public DifficultyLevelReadDTO? DifficultyLevel { get; set; } = null;
        public MuscleReadDTO? PrimeMoverMuscle { get; set; } = null;
        public MuscleReadDTO? SecondaryMoverMuscle { get; set; } = null;
        public MuscleReadDTO? TertiaryMoverMuscle { get; set; } = null;
        public EquipmentReadDTO? PrimaryEquipment { get; set; } = null;
        public EquipmentReadDTO? SecondaryEquipment { get; set; } = null;
        public PostureReadDTO? Posture { get; set; } = null;
        public ExerciseArmTypeReadDTO? ExerciseArmType { get; set; } = null;
        public ExerciseModeReadDTO? ExerciseArmMode { get; set; } = null;
        public GripReadDTO? Grip { get; set; } = null;
        public LoadPositionEndReadDTO? LoadPositionEnd { get; set; } = null;
        public ExerciseModeReadDTO? ExerciseLegMode { get; set; } = null;
        public FootElevationReadDTO? FootElevation { get; set; } = null;
        public CombinationExerciseReadDTO? CombinationExercise { get; set; } = null;
        public PatternReadDTO? PrimaryPattern { get; set; } = null;
        public PatternReadDTO? SecondaryPattern { get; set; } = null;
        public PatternReadDTO? TertiaryPattern { get; set; } = null;
        public PlaneOfMotionReadDTO? PrimaryPlaneOfMotion { get; set; } = null;
        public PlaneOfMotionReadDTO? SecondaryPlaneOfMotion { get; set; } = null;
        public PlaneOfMotionReadDTO? TertiaryPlaneOfMotion { get; set; } = null;
        public BodyRegionReadDTO? BodyRegion { get; set; } = null;
        public ForceTypeReadDTO? ForceType { get; set; } = null;
        public MechanicReadDTO? Mechanic { get; set; } = null;
        public LateralityReadDTO? Laterality { get; set; } = null;
        public ExerciseClassificationReadDTO? ExerciseClassification { get; set; } = null;
    }
}
