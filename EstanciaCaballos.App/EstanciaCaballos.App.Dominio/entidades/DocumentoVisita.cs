using System;

namespace EstanciaCaballos.App.Dominio{
    public class DocumentoVisita{
        public int Id {get; set;}// llave primaria 
        public Caballo caballoAsociado{get;set;}//lave foranea
        public Recomendacion recomendacionVisita{get; set;}//llave foranea
        public string fechaVisita{get; set;}
        public int temperatura {get; set;}
        public int peso{get;set;}
        public int frecuenciaRespiratoria{get;set;}
        public int frecuenciaCardiaca{get;set;}
        public string estadoDeAnimo{get;set;}

        
    }
}