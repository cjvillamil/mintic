// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System;
using EstanciaCaballos.App.Dominio;
using EstanciaCaballos.App.Persistencia;
namespace EstanciaCaballos.App.Consola2{

    class Program{

        
        
        
    private static IRepositorioPersona2 _repoPersona=new RepositorioPersona2(new Persistencia.AppContext());
        static void Main(string[] args){
           Console.WriteLine("Hello, World!");
          // AddPersona1();
          GetPersona2_1("camilo");
        }

        private static void AddPersona1(){
           var persona2=new PersonaPrueba(){
            //Id=5,
            nombre="rodrigo",
            apellido="arias",


           }; 
           _repoPersona.AddPersona2(persona2);
           Console.WriteLine("usuario añadido");
        }

        private static void GetPersona2_1(string nombre){
           
            Console.WriteLine("usuario añadido");
            var persona_encontrada=_repoPersona.GetPersona2(nombre);
            /*if(persona_encontrada!=null){
                
                Console.WriteLine("el nombre es"+persona_encontrada.nombre);
            }else{
                  Console.WriteLine("pailas no esta");
            }*/
        }

        private static void GetAllPersona2(){
            IEnumerable<PersonaPrueba> todos;
           todos= _repoPersona.GetAllPersona2();
            foreach (var PersonaPrueba in todos){
                Console.WriteLine(PersonaPrueba.nombre);
            }
        }
        
    }
}


