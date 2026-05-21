using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RutasPracticaRodri.Pages
{
    public class OficinaModel : PageModel
    {
        private readonly ILogger<OficinaModel> _logger;
        public DateTime FechaCreacion { get; set; } = new DateTime(2026, 5, 10);

        public int DiasDesdeCreacion { get; set; }

        public OficinaModel(ILogger<OficinaModel> logger)
        {
            _logger = logger;
        }


        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public void OnGet()
        {

            if (Id == 0)
            {
                Id = 1;
            }
        }
    }
}