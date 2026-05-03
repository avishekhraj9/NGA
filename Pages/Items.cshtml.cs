using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class ItemsModel : PageModel
{
    public List<string> Items { get; set; }

    public void OnGet()
    {
        Items = new List<string> { "Apple", "Banana", "Mango" };
    }
}