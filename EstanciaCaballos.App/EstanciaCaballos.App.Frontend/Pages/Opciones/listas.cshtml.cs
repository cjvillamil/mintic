using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EstanciaCaballos.App.Frontend.Pages
{
    
    public class listasModel : PageModel
    {
        private string[] vectorLista = {"Ingresar Caballo","Ingreso Veterinario", "Ingreso Propietario","Historia Clinica","Consultar Animales","Consultar Caballo"};
        public List<string> miLista{get;set;}
        public void OnGet()
        {
            miLista = new List<string>();
            miLista.AddRange(vectorLista);
        }
    }
}
