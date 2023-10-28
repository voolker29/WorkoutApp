using BusinessLayerInterfaces.BusinessModels;
using DALInterfaces.Models;

namespace BusinessLayerInterfaces
{
    public interface IUserService
    {
        int? GetUserIdByNameAndPassword(string userName, string password);
        void Save(UserBlm user);
        void Remove(int id);
        UserBlm Get(int id);
    }
}
