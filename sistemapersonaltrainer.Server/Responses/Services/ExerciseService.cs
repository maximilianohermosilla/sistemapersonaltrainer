using AutoMapper;
using sistemapersonaltrainer.Server.Responses.Interfaces;
using sistemapersonaltrainer.Server.Data.Interfaces;
using sistemapersonaltrainer.Server.DTOs;
using sistemapersonaltrainer.Server.Models;

namespace sistemapersonaltrainer.Server.Responses.Services
{
    public class ExerciseService : IExerciseService
    {
        private readonly IExerciseRepository vGblRepository;
        private readonly IConfiguration vGblConfiguration;
        private readonly IMapper vGblMapper;

        public ExerciseService(IExerciseRepository pRepository, IConfiguration pConfiguration, IMapper pMapper)
        {
            vGblRepository = pRepository;
            vGblConfiguration = pConfiguration;
            vGblMapper = pMapper;
        }

        public async Task<ExerciseReadDTO> Create(ExerciseCreateDTO pExercise)
        {
            try
            {
                var vExercise = vGblMapper.Map<Exercise>(pExercise);
                var vExerciseCreada = vGblRepository.Create(vExercise);

                return vGblMapper.Map<ExerciseReadDTO>(vExerciseCreada);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<ExerciseReadDTO> Update(ExerciseCreateDTO pExercise)
        {
            try
            {
                var vExercise = vGblRepository.GetById(pExercise.Id);

                if (vExercise == null)
                {
                    return null;
                }
                else
                {
                    vExercise = vGblMapper.Map<Exercise>(pExercise);
                    vGblRepository.SaveChanges();
                }

                return vGblMapper.Map<ExerciseReadDTO>(vExercise);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> Delete(int pId)
        {
            try
            {
                var vExerciseDeleted = vGblRepository.Delete(pId);

                if (!vExerciseDeleted)
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<IEnumerable<ExerciseReadDTO>> GetAll()
        {
            try
            {
                var vExercises = vGblRepository.GetAll();

                return vGblMapper.Map<IEnumerable<ExerciseReadDTO>>(vExercises);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<ExerciseReadDTO?> GetById(int pId)
        {
            try
            {
                var vExercise = vGblRepository.GetById(pId);

                return vGblMapper.Map<ExerciseReadDTO>(vExercise)!;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
