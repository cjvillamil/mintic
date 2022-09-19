using System.Collections.Generic;  //libreria donde se definen las interfaces
using EstanciaCaballos.App.Dominio;

namespace EstanciaCaballos.App.Persistencia
{
    public interface IRepositorioPersona2
    
        
    
    {
         PersonaPrueba AddPersona2 (PersonaPrueba personaPrueba); 
         void DeletePersona2(int IDPersona);
         IEnumerable<PersonaPrueba> GetAllPersona2(); //IEnumerable es un tipo defindo en C#

         PersonaPrueba GetPersona2(int IDPersona);

    }
 
   
 
} 