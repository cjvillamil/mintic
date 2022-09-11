using System.Collections.Generic;  //libreria donde se definen las interfaces
using EstanciaCaballos.App.Dominio;

namespace EstanciaCaballos.App.Persistencia
{
    public interface IRepositorioPersona
    
        
    
    {
         Persona AddPersona(Persona Persona); 
         void DeletePersona(int IDPersona);
         IEnumerable<Persona> GetAllPersona(); //IEnumerable es un tipo defindo en C#
          Persona GetPersona(int IDPersona);
        Persona UpdatePersona(Persona Persona);
    }
 
   
 
} 