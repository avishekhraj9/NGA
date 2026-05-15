using System.ComponentModel.DataAnnotations;

namespace RegistrationValidationSystem.Models
{
    public class UserRegistration
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(20, MinimumLength = 3,
            ErrorMessage = "Username must be between 3 and 20 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(12, MinimumLength = 6,
            ErrorMessage = "Password must be between 6 and 12 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]

        [Compare("Password",
            ErrorMessage = "Password and Confirm Password do not match")]
        public string ConfirmPassword { get; set; }
    }
}