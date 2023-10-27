using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WorkoutApp.Models.Auth;
using WorkoutApp.Models;
using WorkoutApp.Services;

namespace WorkoutApp.Controllers
{
    public class AuthController : Controller
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var userId = _authService.GetUserIdByNameAndPassword(viewModel.Login, viewModel.Password);
            if (userId == null)
            {
                ModelState.AddModelError(nameof(LoginViewModel.Login), "Не правильный пароль или логин");
                return View(viewModel);
            }

            AuthOnServer(userId.ToString());
            return RedirectToAction("Index", "Home");
        }
        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync().Wait();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserViewModel viewModel)
        {
            _authService.RegisterUser(viewModel);
            return View();
        }

        private void AuthOnServer(string userId)
        {
            var claims = new List<Claim>() {
                new Claim("Id", userId),
                new Claim("TimeOfLogin", DateTime.Now.Hour + ""),
                new Claim(ClaimTypes.AuthenticationMethod, "WebAuth")
            };

            var identity = new ClaimsIdentity(claims, "WebAuth");

            var principal = new ClaimsPrincipal(identity);

            HttpContext.SignInAsync(principal).Wait();
        }
    }
}
