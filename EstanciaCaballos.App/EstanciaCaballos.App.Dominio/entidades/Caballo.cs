using System;


namespace EstanciaCaballos.App.Dominio{
    public class Caballo{
        public int Id {get; set;}//primary key
        //public Historia historiaCaballo{get;set;}//llave foranea
        public Veterinario veterinarioAsignado{get; set;}
        public Persona propietario{get; set;}
        public string color{get; set;}
        public string raza {get; set;}
        public string especie  {get; set;}   

    }
}