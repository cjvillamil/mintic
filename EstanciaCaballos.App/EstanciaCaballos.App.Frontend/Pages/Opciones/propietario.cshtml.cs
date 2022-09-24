using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EstanciaCaballos.App.Dominio;
using EstanciaCaballos.App.Persistencia;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstanciaCaballos.App.Frontend.Pages
{
    public class propietarioModel : PageModel
    {
        private readonly IRepositorioPersona repositorioPersona;
        public IEnumerable<Persona> propietarios;
        public propietarioModel(){
            this.repositorioPersona = new RepositorioPersona(new EstanciaCaballos.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            propietarios = repositorioPersona.GetAllPersona();
        }
    }
}
