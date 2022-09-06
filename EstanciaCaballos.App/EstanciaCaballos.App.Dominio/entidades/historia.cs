using System;

namespace EstanciaCaballos.App.Dominio{
    public class historia{
        public int visitas_realizadas{get; set;}
        public caballo caballo_asociado{get; set;}//llave foranea
        public string fecha_inicio_historia{get;set;}
        public int id{get;set;}//llave primaria
    }
}