using DALInterfaces.Models;

namespace DALInterfaces.Repositories
{
    public interface IUserRepository : IBaseRepository<UserModel>
    {
        int? GetUserIdByNameAndPassword(string userName, string password);
    }
}
