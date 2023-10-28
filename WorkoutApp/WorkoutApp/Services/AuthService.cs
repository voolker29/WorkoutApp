using BusinessLayerInterfaces;
using BusinessLayerInterfaces.BusinessModels;
using WorkoutApp.Models;

namespace WorkoutApp.Services
{
    public class AuthService : IAuthService
    {
        private IUserService _userService;
        private IHttpContextAccessor _httpContextAccessor;
        public AuthService(IUserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
        }
        public UserViewModel GetCurrentUser()
        {
            var idStr = GetIdStr();
            var id = int.Parse(idStr);
            var user = _userService.Get(id);

            return new UserViewModel { Email = user.Email, Login = user.Login, UserName = user.UserName };
        }

        public int? GetUserIdByNameAndPassword(string userName, string password)
        =>    _userService.GetUserIdByNameAndPassword(userName, password);

        public void RegisterUser(UserViewModel userViewModel)
        {
            _userService.Save(new UserBlm
            { 
                Email = userViewModel.Email, 
                Login = userViewModel.Login, 
                Password = userViewModel.Password, 
                UserName = userViewModel.UserName 
            });
            
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
    }
}
