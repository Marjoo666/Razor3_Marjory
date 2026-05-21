using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RutasPracticaRodri.Pages.Empleados
{
    public class ClienteModel : PageModel
    {
        public List<string> ListaClientes { get; set; } = new List<string>();
        public void OnGet()
        {
            ListaClientes.Add("Enzo Rado Polo Dior");
            ListaClientes.Add("Rodrigo Heriberto Carballo Aguilar");
            ListaClientes.Add("Diego Jose Velasquez Martinez");
            ListaClientes.Add("Maria Jose Gutierrez Fernández");
        }
    }
}
