using System;

namespace EstanciaCaballos.App.Dominio{
    public class documento_visita{
        public int id{get; set;}// llave primaria 
        public caballo caballo_asociado{get;set;}//lave foranea
        public recomendaciones recomendaciones_visita{get; set;}//llave foranea
        public string fecha_visita{get; set;}
        public int temperatura {get; set;}
        public int peso{get;set;}
        public int frecuencia_respiratoria{get;set;}
        public int frecuencia_cardiaca{get;set;}
        public string estado_de_animo{get;set;}

        
    }
}