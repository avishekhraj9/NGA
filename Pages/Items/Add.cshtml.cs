using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorItemApp.Models;
using RazorItemApp.Services;

namespace RazorItemApp.Pages.Items
{
    public class AddModel : PageModel
    {
        private readonly ItemService _service;

        [BindProperty]
        public Item NewItem { get; set; }

        public AddModel(ItemService service)
        {
            _service = service;
        }

        // Handle form submission
        public IActionResult OnPost()
        {
            _service.AddItem(NewItem);

            // Redirect to list page
            return RedirectToPage("/Items/Index");
        }
    }
}