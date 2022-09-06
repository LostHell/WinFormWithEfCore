using AMRDb.Models;

namespace AMRServices.Services
{
    public interface IUserServices
    {
        Task<User> CreateNewUser(string name, int age);
    }
}
