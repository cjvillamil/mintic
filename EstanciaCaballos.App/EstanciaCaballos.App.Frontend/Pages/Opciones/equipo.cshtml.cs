using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EstanciaCaballos.App.Frontend.Pages
{
    public class equipoModel : PageModel
    {
        public List<Equipo> miLista{get;set;}
        public void OnGet()
        {
            miLista = new List<Equipo>();
            miLista.Add(new Equipo("Fernanda","Lider Proyecto",new List<string>(new []{ "Intermediario con los interesados.", "Coordina el seguimineto del plan.", "Motiva al equipo para seguir el proceso."})));
            miLista.Add(new Equipo("Juan Camilo","Diseñador Software",new List<string>(new []{ "Analizar los requisitos.","Elaborar el diseño del software(backend).","Verificar que se cumplo con el diseño."})));
            miLista.Add(new Equipo("Fabian","Administrador de configuracion",new List<string>(new []{ "Configurar el repositorio.","Dar soporte para la integración y despliegue."})));
            miLista.Add(new Equipo("Marco","Tester",new List<string>(new []{ "Diseñar pruebas a partir de los requisitos.","Ejecutar pruebas y revisiones para encontrar errores."})));
            miLista.Add(new Equipo("Carol","Diseñador UI",new List<string>(new []{ "Analizar los requisitos.","Elaborar el diseño de la UI.","Elaborar maquetas de base para el frontend."})));
            
        }
    }
}
