using BusinessLayerInterfaces;
using BusinessLayerInterfaces.BusinessModels;
using DALInterfaces.Models;
using DALInterfaces.Repositories;

namespace BusinessLayer
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public int? GetUserIdByNameAndPassword(string userName, string password)
        {
            return _userRepository.GetUserIdByNameAndPassword(userName, password);
        }

        public void Remove(int id)
        {
            _userRepository.Remove(id);
        }

        public void Save(UserBLM user)
        {
            _userRepository.Save(MapUserBlmToUser(user));
        }

        public UserBLM Get(int id)
        => MapUserToUserBLM(_userRepository.Get(id));

        public UserBLM MapUserToUserBLM(User user)
        => new UserBLM
        {
            Email = user.Email,
            Id = user.Id,
            Login = user.Login,
            Password = user.Password,
            UserName = user.UserName
        };

        public User MapUserBlmToUser(UserBLM userBLM)
        => new User
        {
            Email = userBLM.Email,
            Id = userBLM.Id,
            Login = userBLM.Login,
            Password = userBLM.Password,
            UserName = userBLM.UserName
        };
    }
}
