using System;
using System.ComponentModel.DataAnnotations;

namespace EstanciaCaballos.App.Dominio{
    public class DocumentoVisita{
        [Key]
        public int Id {get; set;}// llave primaria 
        public int  Id_caballoAsociado{get;set;}//lave foranea
        public int Id_recomendacionVisita{get; set;}//llave foranea
        public string fechaVisita{get; set;}
        public int temperatura {get; set;}
        public int peso{get;set;}
        public int frecuenciaRespiratoria{get;set;}
        public int frecuenciaCardiaca{get;set;}
        public string estadoDeAnimo{get;set;}

        
    }
}