using System.Collections.Generic;
using EstanciaCaballos.App.Dominio;
using System.Linq;

namespace EstanciaCaballos.App.Persistencia
{
    public class RepositorioPersona2 : IRepositorioPersona2
    {
        private readonly AppContext _appContext; //instancia de Objeto de Clase AppContext



        public RepositorioPersona2(AppContext AppContext){
            _appContext=AppContext;
        } //Cosntructor Clase RepositorioPaciente
                
        PersonaPrueba IRepositorioPersona2.AddPersona2(PersonaPrueba Persona2_2)
        {
            var Persona2Adicionado = _appContext.persona2.Add(Persona2_2);
            _appContext.SaveChanges();
            return Persona2Adicionado.Entity;

        }

         void IRepositorioPersona2.DeletePersona2(int IDPersona)
        {
            var Persona2Encontrado = _appContext.persona2.FirstOrDefault(p => p.Id == IDPersona);
            if (Persona2Encontrado == null)
            {
                return;
            }
            _appContext.persona2.Remove(Persona2Encontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<PersonaPrueba> IRepositorioPersona2.GetAllPersona2()
        {
            return _appContext.persona2;

        }
        //IE
         PersonaPrueba IRepositorioPersona2.GetPersona2(int IDPersona)
        {
             var PersonaEncontrado = _appContext.persona2.FirstOrDefault(u => u.Id == IDPersona); //Id proviene de clase Persona por herencia
            Console.WriteLine(PersonaEncontrado.nombre);
            return  PersonaEncontrado;//_appContext.persona2.FirstOrDefault(p => p.Id== IDPersona);
        }
        
    }
}