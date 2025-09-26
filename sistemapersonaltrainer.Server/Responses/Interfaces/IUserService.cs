using sistemapersonaltrainer.Server.DTOs;

namespace sistemapersonaltrainer.Server.Responses.Interfaces
{
    public interface IUserService
    {
        Task<UserReadDTO?> Create(UserCreateDTO pUser);
        Task<IEnumerable<UserReadDTO>> GetAll();
        Task<UserReadDTO?> GetById(int pId);
        Task<UserReadDTO?> GetByUserNamePassword(string pUserName, string pPassword);
    }
}
