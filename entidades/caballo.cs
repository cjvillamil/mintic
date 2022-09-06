using System;


namespace EstanciaCaballos.App.Dominio{
    public class caballo{
        
        public veterinario veterinario_asignado{get; set;}
        public persona propietario{get; set;}
        public string color{get; set;}
        public string raza {get; set;}
        public string especie  {get; set;}

        public int id{get; set;}//lave primaria
        public int historia_caballo{get;set;}//llave foranea
        

    }
}