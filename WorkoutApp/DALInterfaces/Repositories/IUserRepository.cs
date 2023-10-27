using DALInterfaces.Models;

namespace DALInterfaces.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        int? GetUserIdByNameAndPassword(string userName, string password);
    }
}
