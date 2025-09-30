using AutoMapper;
using sistemapersonaltrainer.Server.DTOs;
using sistemapersonaltrainer.Server.Models;

namespace sistemapersonaltrainer.Server.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile(IMapperConfigurationExpression config)
        {
            config.CreateMap<BodyRegion, BodyRegionReadDTO>().ReverseMap();
            config.CreateMap<BodyRegion, BodyRegionCreateDTO>().ReverseMap();

            config.CreateMap<CombinationExercise, CombinationExerciseReadDTO>().ReverseMap();
            config.CreateMap<CombinationExercise, CombinationExerciseCreateDTO>().ReverseMap();

            config.CreateMap<Customer, CustomerReadDTO>().ReverseMap();
            config.CreateMap<Customer, CustomerCreateDTO>().ReverseMap();

            config.CreateMap<DifficultyLevel, DifficultyLevelReadDTO>().ReverseMap();
            config.CreateMap<DifficultyLevel, DifficultyLevelCreateDTO>().ReverseMap();

            config.CreateMap<Equipment, EquipmentReadDTO>().ReverseMap();
            config.CreateMap<Equipment, EquipmentCreateDTO>().ReverseMap();

            config.CreateMap<Exercise, ExerciseReadDTO>().ReverseMap();
            config.CreateMap<Exercise, ExerciseCreateDTO>().ReverseMap();

            config.CreateMap<ExerciseArmType, ExerciseArmTypeReadDTO>().ReverseMap();
            config.CreateMap<ExerciseArmType, ExerciseArmTypeCreateDTO>().ReverseMap();

            config.CreateMap<ExerciseClassification, ExerciseClassificationReadDTO>().ReverseMap();
            config.CreateMap<ExerciseClassification, ExerciseClassificationCreateDTO>().ReverseMap();

            config.CreateMap<ExerciseMode, ExerciseModeReadDTO>().ReverseMap();
            config.CreateMap<ExerciseMode, ExerciseModeCreateDTO>().ReverseMap();

            config.CreateMap<FootElevation, FootElevationReadDTO>().ReverseMap();
            config.CreateMap<FootElevation, FootElevationCreateDTO>().ReverseMap();

            config.CreateMap<ForceType, ForceTypeReadDTO>().ReverseMap();
            config.CreateMap<ForceType, ForceTypeCreateDTO>().ReverseMap();

            config.CreateMap<Grip, GripReadDTO>().ReverseMap();
            config.CreateMap<Grip, GripCreateDTO>().ReverseMap();

            config.CreateMap<Laterality, LateralityReadDTO>().ReverseMap();
            config.CreateMap<Laterality, LateralityCreateDTO>().ReverseMap();

            config.CreateMap<LoadPositionEnd, LoadPositionEndReadDTO>().ReverseMap();
            config.CreateMap<LoadPositionEnd, LoadPositionEndCreateDTO>().ReverseMap();

            config.CreateMap<Mechanic, MechanicReadDTO>().ReverseMap();
            config.CreateMap<Mechanic, MechanicCreateDTO>().ReverseMap();

            config.CreateMap<Muscle, MuscleReadDTO>().ReverseMap();
            config.CreateMap<Muscle, MuscleCreateDTO>().ReverseMap();

            config.CreateMap<MuscleGroup, MuscleGroupReadDTO>().ReverseMap();
            config.CreateMap<MuscleGroup, MuscleGroupCreateDTO>().ReverseMap();

            config.CreateMap<Parameter, ParameterReadDTO>().ReverseMap();
            config.CreateMap<Parameter, ParameterCreateDTO>().ReverseMap();

            config.CreateMap<Pattern, PatternReadDTO>().ReverseMap();
            config.CreateMap<Pattern, PatternCreateDTO>().ReverseMap();

            config.CreateMap<PlaneOfMotion, PlaneOfMotionReadDTO>().ReverseMap();
            config.CreateMap<PlaneOfMotion, PlaneOfMotionCreateDTO>().ReverseMap();

            config.CreateMap<Posture, PostureReadDTO>().ReverseMap();
            config.CreateMap<Posture, PostureCreateDTO>().ReverseMap();

            config.CreateMap<User, UserReadDTO>().ReverseMap();
            config.CreateMap<User, UserCreateDTO>().ReverseMap();

            config.CreateMap<User, UserReadDTO>().ReverseMap();
            config.CreateMap<User, UserCreateDTO>().ReverseMap();
            config.CreateMap<User, UserLoginDTO>().ReverseMap();
            config.CreateMap<User, UserLoginReadDTO>().ReverseMap();

            config.CreateMap<Workout, WorkoutReadDTO>().ReverseMap();
            config.CreateMap<Workout, WorkoutCreateDTO>().ReverseMap();

            config.CreateMap<WorkoutActivity, WorkoutActivityReadDTO>().ReverseMap();
            config.CreateMap<WorkoutActivity, WorkoutActivityCreateDTO>().ReverseMap();

            config.CreateMap<WorkoutActivityExercise, WorkoutActivityExerciseReadDTO>().ReverseMap();
            config.CreateMap<WorkoutActivityExercise, WorkoutActivityExerciseCreateDTO>().ReverseMap();
        }
    }
}

