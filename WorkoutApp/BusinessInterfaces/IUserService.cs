using BusinessLayerInterfaces.BusinessModels;
using DALInterfaces.Models;

namespace BusinessLayerInterfaces
{
    public interface IUserService
    {
        int? GetUserIdByNameAndPassword(string userName, string password);
        void Save(UserBLM user);
        void Remove(int id);
        UserBLM Get(int id);
    }
}
