
using System.Collections.Generic;
using EstanciaCaballos.App.Dominio;
using System.Linq;

namespace EstanciaCaballos.App.Persistencia
{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly AppContext _appContext; //instancia de Objeto de Clase AppContext



        public RepositorioPersona(AppContext AppContext){
            _appContext=AppContext;
        } //Cosntructor Clase RepositorioPaciente
                
        Persona IRepositorioPersona.AddPersona(Persona Persona)
        {
            var PersonaAdicionado = _appContext.Personas.Add(Persona);
            _appContext.SaveChanges();
            return PersonaAdicionado.Entity;

        }
        void IRepositorioPersona.DeletePersona(int IDPersona)
        {
            var PersonaEncontrado = _appContext.Personas.FirstOrDefault(p => p.Id == IDPersona);
            if (PersonaEncontrado == null)
            {
                return;
            }
            _appContext.Personas.Remove(PersonaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Persona> IRepositorioPersona.GetAllPersona()
        {
            return _appContext.Personas;

        }
        //IEnumerable es un tipo defindo en C#

        Persona IRepositorioPersona.GetPersona(int IDPersona)
        {
            var PersonaEncontrado = _appContext.Personas.FirstOrDefault(p=>p.Id== IDPersona); //Id proviene de clase Persona por herencia

            return PersonaEncontrado;
        }

        Persona IRepositorioPersona.UpdatePersona(Persona Persona)
        {
            var PersonaEncontrado = _appContext.Personas.FirstOrDefault(p => p.Id == Persona.Id); //Id proviene de clase Persona por herencia
            if (PersonaEncontrado != null)
            {
                PersonaEncontrado.nombre = Persona.nombre;
                PersonaEncontrado.apellido = Persona.apellido;
                //Incluir demás Atributos
                _appContext.SaveChanges();
            }
            return PersonaEncontrado;
        }
    }
}