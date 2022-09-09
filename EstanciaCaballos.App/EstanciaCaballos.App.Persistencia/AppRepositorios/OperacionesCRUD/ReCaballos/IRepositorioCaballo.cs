using System.Collections.Generic;  //libreria donde se definen las interfaces
using EstanciaCaballos.App.Dominio;

namespace EstanciaCaballos.App.Persistencia
{
    public interface IRepositorioCaballo
    {
        Caballo AddCaballo(Caballo caballo);
        void DeleteCaballo(int IDCaballo);
        IEnumerable<Caballo> GetAllCaballo(); //IEnumerable es un tipo defindo en C#
        Caballo GetCaballo(int IDCaballo);
        Caballo UpdateCaballo(Caballo caballo);
    }
 
   
 
} 