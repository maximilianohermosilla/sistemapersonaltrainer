using sistemapersonaltrainer.Server.DTOs;

namespace sistemapersonaltrainer.Server.Responses.Interfaces
{
    public interface ICustomerService
    {
        Task<CustomerReadDTO?> Create(CustomerCreateDTO pCustomer);
        Task<IEnumerable<CustomerReadDTO>> GetAll();
        Task<CustomerReadDTO?> GetById(int pId);
        Task<CustomerReadDTO?> GetByEmailOrPhone(string pEmail, string pPhone);
    }
}
