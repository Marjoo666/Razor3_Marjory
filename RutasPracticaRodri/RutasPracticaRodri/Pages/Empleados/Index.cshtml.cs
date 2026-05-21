using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RutasPracticaRodri.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Nombre { get; set; }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Nombre))
            {
                Nombre = "Santiago Aguirre";
            }
        }
    }
}