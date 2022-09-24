using System;
using System.ComponentModel.DataAnnotations;

namespace EstanciaCaballos.App.Dominio{
    public class Historia{
       [Key]
        public int Id{get;set;}//llave primaria
        public int visitasRealizadas{get; set;}
        public int Id_caballoAsociado{get; set;}//llave foranea
        public string fechaInicioHistoria{get;set;}
        
    }
}