using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Practica.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public List<Person> ListPerson { get; set; }
    public void OnGet()
    {
        ListPerson = personService.GetAll();
    }

    public IActionResult OnPostDelete(int id)
    {
        if (id == null)
        {
            return RedirectToAction("Error");
        }
        personService.delete(id);
        return RedirectToAction("get");
    }
}
