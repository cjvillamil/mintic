using System.Collections.Generic;  //libreria donde se definen las interfaces
using EstanciaCaballos.App.Dominio;

namespace EstanciaCaballos.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        Veterinario AddVeterinario(Veterinario veterinario);
        void DeleteVeterinario(int IDVeterinario);
        IEnumerable<Veterinario> GetAllVeterinario(); //IEnumerable es un tipo defindo en C#
        Veterinario GetVeterinario(int IDVeterinario);
        Veterinario UpdateVeterinario(Veterinario Veterinario);
    }
 
   
 
} 