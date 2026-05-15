using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RegistrationValidationSystem.Models;

namespace RegistrationValidationSystem.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public UserRegistration UserData { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("Success");
        }
    }
}