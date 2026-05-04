using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorItemApp.Models;
using RazorItemApp.Services;
using System.Collections.Generic;

namespace RazorItemApp.Pages.Items
{
    public class IndexModel : PageModel
    {
        private readonly ItemService _service;

        public List<Item> Items { get; set; }

        // Constructor (Dependency Injection)
        public IndexModel(ItemService service)
        {
            _service = service;
        }

        // Runs when page loads
        public void OnGet()
        {
            Items = _service.GetItems();
        }
    }
}