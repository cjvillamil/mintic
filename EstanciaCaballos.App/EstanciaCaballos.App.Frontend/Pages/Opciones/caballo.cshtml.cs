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
    public class caballoModel : PageModel
    {
        private readonly IRepositorioCaballo repositorioCaballo;
        public IEnumerable<Caballo> caballos{set;get;} 

        public caballoModel(){
            this.repositorioCaballo = new RepositorioCaballo(new EstanciaCaballos.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            caballos = repositorioCaballo.GetAllCaballos();
        }
    }
}
