using sistemapersonaltrainer.Server.Models;

namespace sistemapersonaltrainer.Server.Data.Interfaces
{
    public interface IParameterRepository
    {
        bool SaveChanges();
        IEnumerable<Parameter> GetAll();
        Parameter GetById(int pId);
        Parameter GetByKey(string pKey);
        Parameter Create(Parameter pParameter);
    }
}
