using System;
using System.ComponentModel.DataAnnotations;

namespace  EstanciaCaballos.App.Dominio{
    public class Persona{
        [Key]
        public int Id {get; set;}//primary key
        public string nombre {get; set;}
        public string apellido {get; set;}
        public string direccion {get; set;}
        public string telefono {get; set;}
        public string correo  {get; set;}

    }
}