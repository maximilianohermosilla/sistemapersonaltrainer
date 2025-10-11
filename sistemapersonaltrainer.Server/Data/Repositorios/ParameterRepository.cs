using sistemapersonaltrainer.Server.Data.Interfaces;
using sistemapersonaltrainer.Server.Models;

namespace sistemapersonaltrainer.Server.Data.Repositories
{
    public class ParameterRepository: IParameterRepository
    {
        private readonly AppDbContext vGblContext;

        public ParameterRepository(AppDbContext pContext)
        {
            vGblContext = pContext;
        }
        public bool SaveChanges()
        {
            return vGblContext.SaveChanges() > 0;
        }

        public Parameter Create(Parameter pParameter)
        {
            vGblContext.Parameters.Add(pParameter);
            vGblContext.SaveChanges();

            return pParameter;
        }

        public IEnumerable<Parameter> GetAll()
        {
            return vGblContext.Parameters.ToList();
        }

        public Parameter GetById(int pId)
        {
            return vGblContext.Parameters.FirstOrDefault(e => e.Id == pId)!;
        }

        public Parameter GetByKey(string pKey)
        {
            return vGblContext.Parameters.FirstOrDefault(e => e.Key == pKey)!;
        }
    }
}
