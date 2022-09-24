using System;
using System.ComponentModel.DataAnnotations;


namespace EstanciaCaballos.App.Dominio{
    public class Caballo{
        [Key]
        public int Id {get; set;}//primary key
        public int  Id_veterinarioAsignado{get; set;}
        public int Id_propietario{get; set;}
        public int  Id_finca  {get; set;}  
        public string nombre  {get; set;}  
        public string color{get; set;}
        public string raza {get; set;}
        public string especie  {get; set;}   
    }
}
