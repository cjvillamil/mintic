using System.Collections.Generic;
using EstanciaCaballos.App.Dominio;
using System.Linq;

namespace EstanciaCaballos.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        private readonly AppContext _appContext; //instancia de Objeto de Clase AppContext



        public RepositorioVeterinario(AppContext AppContext){
            _appContext=AppContext;
        } //Cosntructor Clase RepositorioPaciente
                
        Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario  veterinario_1)
        {
            var PersonaAdicionado = _appContext.Veterinarios.Add(veterinario_1);
            _appContext.SaveChanges();
            return PersonaAdicionado.Entity;

        }
        void IRepositorioVeterinario.DeleteVeterinario(int IDPersona)
        {
            var PersonaEncontrado = _appContext.Veterinarios.FirstOrDefault(p => p.Id == IDPersona);
            if (PersonaEncontrado == null)
            {
                return;
            }
            _appContext.Veterinarios.Remove(PersonaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Veterinario> IRepositorioVeterinario.GetAllVeterinario()
        {
            return _appContext.Veterinarios;

        }
        //IEnumerable es un tipo defindo en C#

        Veterinario IRepositorioVeterinario.GetVeterinario(int IDVeterinario)
        {
            var PersonaEncontrado = _appContext.Veterinarios.FirstOrDefault(p=>p.Id== IDVeterinario); //Id proviene de clase Persona por herencia

            return PersonaEncontrado;
        }

        Veterinario IRepositorioVeterinario.UpdateVeterinario (Veterinario veterinario_2)
        {
            var veterinario_Encontrado = _appContext.Veterinarios.FirstOrDefault(p => p.Id == veterinario_2.Id); //Id proviene de clase Persona por herencia
            if (veterinario_Encontrado != null)
            {
                veterinario_Encontrado.nombre = veterinario_2.nombre;
                veterinario_Encontrado.apellido = veterinario_2.apellido;
                //Incluir demás Atributos
                _appContext.SaveChanges();
            }
            return veterinario_Encontrado;
        }
    }
}
