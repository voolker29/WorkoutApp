using DALInterfaces.Models;
using DALInterfaces.Repositories;

namespace DALEF.Repositories
{
    public class UserRepository : BaseRepository<UserModel>, IUserRepository
    {
        public UserRepository(WebContext context) : base(context) { }

        public int? GetUserIdByNameAndPassword(string userName, string password)
        {
            return _dbSet
                .FirstOrDefault(x => x.UserName == userName && x.Password == password)
                ?.Id;
        }
    }
}
