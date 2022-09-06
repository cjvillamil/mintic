using System;

namespace EstanciaCaballos.App.Dominio{
    public class Veterinario : Persona{
        public int Id {get; set;}//primary key

        public String licencia {get; set;}
        public Boolean estaDisponible {get;set;}
        public String horarioAtencion {get;set;}
    }
}