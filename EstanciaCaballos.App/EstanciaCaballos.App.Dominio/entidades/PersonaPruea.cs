using System;
using System.ComponentModel.DataAnnotations;

namespace  EstanciaCaballos.App.Dominio{
    public class PersonaPrueba{
        [Key]
        public int Id {get; set;}//primary key
        public string nombre {get; set;}
        public string apellido {get; set;}

    }
}