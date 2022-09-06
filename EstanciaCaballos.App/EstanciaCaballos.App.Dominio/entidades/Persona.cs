using System;

namespace  EstanciaCaballos.App.Dominio{
    public class Persona{
        public int Id {get; set;}//primary key
        public string nombre {get; set;}
        public string apellido {get; set;}
        public string direccion {get; set;}
        public string telefono {get; set;}
        public string correo  {get; set;}

    }
}