using System;

namespace HospitalCasa.App.Dominio{
    public class paciente: persona{
        public string direccion{get; set;}
        public string latitud{get; set;}
        public string longitud{get; set;}
        public string ciudad{ get; set;}
        public string fecha{get;set;}
    }
}

