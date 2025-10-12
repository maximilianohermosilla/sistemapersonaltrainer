using AutoMapper;
using sistemapersonaltrainer.Server.Responses.Interfaces;
using sistemapersonaltrainer.Server.Data.Interfaces;
using sistemapersonaltrainer.Server.DTOs;
using sistemapersonaltrainer.Server.Models;

namespace sistemapersonaltrainer.Server.Responses.Services
{
    public class WorkoutService : IWorkoutService
    {
        private readonly IWorkoutRepository vGblRepository;
        private readonly IConfiguration vGblConfiguration;
        private readonly IMapper vGblMapper;

        public WorkoutService(IWorkoutRepository pRepository, IConfiguration pConfiguration, IMapper pMapper)
        {
            vGblRepository = pRepository;
            vGblConfiguration = pConfiguration;
            vGblMapper = pMapper;
        }

        public async Task<WorkoutReadDTO> Create(WorkoutCreateDTO pWorkout)
        {
            try
            {
                var vWorkout = vGblMapper.Map<Workout>(pWorkout);
                var vWorkoutCreada = vGblRepository.Create(vWorkout);

                return vGblMapper.Map<WorkoutReadDTO>(vWorkoutCreada);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<WorkoutReadDTO> Update(WorkoutCreateDTO pWorkout)
        {
            try
            {
                var vWorkout = vGblRepository.GetById(pWorkout.Id);

                if (vWorkout == null)
                {
                    return null;
                }
                else
                {
                    vWorkout = vGblMapper.Map<Workout>(pWorkout);
                    vGblRepository.SaveChanges();
                }

                return vGblMapper.Map<WorkoutReadDTO>(vWorkout);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<WorkoutReadDTO>> GetAll()
        {
            try
            {
                var vWorkouts = vGblRepository.GetAll();

                return vGblMapper.Map<IEnumerable<WorkoutReadDTO>>(vWorkouts);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<WorkoutReadDTO?> GetById(int pId)
        {
            try
            {
                var vWorkout = vGblRepository.GetById(pId);

                return vGblMapper.Map<WorkoutReadDTO>(vWorkout)!;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
