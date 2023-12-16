using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica;

namespace MyApp.Namespace
{
    [BindProperties]
    public class ViewModel : PageModel
    {

        public Person person { get; set; } = default!;
        public void OnGet(int id)
        {
            if (id == null)
            {
                RedirectToAction("Error");
            }
            person = personService.Get(id);
        }
    }
}
