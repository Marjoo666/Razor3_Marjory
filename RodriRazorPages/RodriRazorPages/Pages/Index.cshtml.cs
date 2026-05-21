using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RodriRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string Visitante { get; set; }
        public string fecha { get; set; }
        public List<string> Visitantes = new List<string>();
        //Ejercicio practico pagina 40
        public DateTime FechaCreacion { get; set; } = new DateTime(2026, 05, 13);
        public int DiasCreacion { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Visitante = "Rodrigo";
            fecha = DateTime.Now.ToString();

            Visitantes.Add("Matias");
            Visitantes.Add("Micaela");
            Visitantes.Add("Andres");
            Visitantes.Add("Marta");

            //parte de los ejercicios pagina 40
            //primer se captura la fecha actual
            DateTime fechaActual = DateTime.Now;

            //hacemos el calculo
            TimeSpan diferencia = fechaActual - FechaCreacion;

            // Guardamos solo el número de días en la propiedad
            DiasCreacion = diferencia.Days;
        }
    }
}
