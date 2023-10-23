﻿using System.ComponentModel.DataAnnotations;

namespace WorkoutApp.Models.Auth
{
    public class LoginViewModel
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
