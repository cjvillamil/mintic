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
    public class veterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;
        public IEnumerable<Veterinario> veterinarios;

        public veterinarioModel(){
            this.repositorioVeterinario = new RepositorioVeterinario(new EstanciaCaballos.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            veterinarios = repositorioVeterinario.GetAllVeterinario();
        }
    }
}
