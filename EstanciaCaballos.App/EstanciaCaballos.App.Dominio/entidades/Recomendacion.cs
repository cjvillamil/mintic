using System;
using System.ComponentModel.DataAnnotations;

namespace EstanciaCaballos.App.Dominio{
    public class Recomendacion{
        [Key]
        public int Id {get; set;}//primary key
        public string medicamentos{get; set;}
        public string dosisMedicamento{get;set;}
        public string frecuenciaMedicamento{get;set;}
        public string cuidados{get; set;}
        
    }
}