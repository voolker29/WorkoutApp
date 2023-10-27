using WorkoutApp.Models;

namespace WorkoutApp.Services
{
    public interface IAuthService
    {
        UserViewModel GetCurrentUser();
        int? GetUserIdByNameAndPassword(string userName, string password);
        void RegisterUser(UserViewModel userViewModel);

    }
}
