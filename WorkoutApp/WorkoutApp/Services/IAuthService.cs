using WorkoutApp.Models;

namespace WorkoutApp.Services
{
    public interface IAuthService
    {
        UserViewModel GetCurrentUser();
        void SaveUser(UserViewModel userViewModel);
        int? GetUserIdByNameAndPassword(string userName, string password);
    }
}
