using DALInterfaces.Models;
using DALInterfaces.Repositories;
using WorkoutApp.Models;

namespace WorkoutApp.Services
{
    public class AuthService : IAuthService
    {
        private IUserRepository _userRepository;
		private IHttpContextAccessor _httpContextAccessor;
        public AuthService(IUserRepository userRepository, IHttpContextAccessor httpContextAccessor) 
        {
          _httpContextAccessor = httpContextAccessor;
            _userRepository = userRepository;
        }
        public UserViewModel GetCurrentUser()
        {
            var idStr = GetIdStr();
            var id = int.Parse(idStr);
            var user = _userRepository.Get(id);

            return new UserViewModel { Email = user.Email,Login = user.Login,UserName = user.UserName };
        }

        private string GetIdStr()
        {
            return _httpContextAccessor
                .HttpContext
                .User
                .Claims
                .First(x => x.Type == "Id")
                .Value;
        }
        public void SaveUser(UserViewModel userViewModel)
        {
            _userRepository.Save(new User
            {
                Email = userViewModel.Email,
                Login = userViewModel.Login,
                Password = userViewModel.Password,
                UserName = userViewModel.UserName
            });        
        }
        public int? GetUserIdByNameAndPassword(string userName, string password)
        {
            return _userRepository.GetUserIdByNameAndPassword(userName, password);
        }
    }
}
