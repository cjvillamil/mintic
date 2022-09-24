using System;
using System.ComponentModel.DataAnnotations;


namespace EstanciaCaballos.App.Dominio{
    public class Finca{
        [Key]
        public int Id {get; set;}//primary key
        public string nombre {get; set;}
        public string direccion {get; set;}
        public string telefono {get; set;}
     }
}
