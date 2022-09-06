using System;

namespace EstanciaCaballos.App.Dominio{
    public class Historia{

        public int Id{get;set;}//llave primaria
        public int visitasRealizadas{get; set;}
        public Caballo caballoAsociado{get; set;}//llave foranea
        public string fechaInicioHistoria{get;set;}
        
    }
}