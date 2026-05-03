using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class AddItemModel : PageModel
{
    [BindProperty]
    public string NewItem { get; set; }

    public string Message { get; set; }

    public void OnPost()
    {
        Message = "Item Added: " + NewItem;
    }
}