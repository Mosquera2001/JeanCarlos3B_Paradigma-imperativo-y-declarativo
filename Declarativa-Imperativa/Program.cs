using System;
using System.Collections.Generic;
using System.Linq;

namespace Declarativa_Imperativa
{
    class Program
    {
        static void Main(string[] args)
        {

            var personas = new List<Persona>() //Creamos un elemento de tipo lista de la clase creada
          {
                //Creamos unos obehetos y colocamos lo datos en las variables
                //El paradigma funcional se combina con objetos
              new Persona(){Nombre="Carlos", Ciudad="Manta", Beber=true},
              new Persona(){Nombre="Pedro", Ciudad="Portoviejo", Beber=true},
              new Persona(){Nombre="Juan", Ciudad="Guayaquil", Beber=false},
              new Persona(){Nombre="Marlon", Ciudad="Quito", Beber=true},
              new Persona(){Nombre="Manuel", Ciudad="Montecristi", Beber=false},
 
          };

            //Paradigma Imperativo

            var bebengaseosa = new List<string>();  //Creamos un objeto resultante para saber los nombres de las personas que beben 
                                                    // Y una lista de tipo String
            foreach(var persona in personas)
                // Creamos un foreach para indicarle lo que tiene que hacer
            {
                if (persona.Beber) //Aquí evaluamos si los elementos que estan siendo recorridos beben gaseosa
                    bebengaseosa.Add(persona.Nombre.ToUpper());
                // Vamos a tener los nombres de las personas que beben en bebemgaseosa

                //Este seria el paradigma Imperativo, donde le indicamos al computador que hacer y como hacerlo para saber
                // los nombres de las personas que beben gaseosa
            }
            
            
            //Paradigma Declarativo

            var bebengaseosa2 = personas.Where(d => d.Beber) //Creamos un objeto resultante, con una funcion llamada Where que resive una expresion 
                                                             //Y que es lo que tiene que hacer de tipo Font
                
                .Select(d => d.Nombre.ToUpper()); // Selecionamos el elemento a una funcion de extension al elemento nombre y que este ToUpper

            //Podemos ver que en este paradigma no se le dice como hacer al computador, le indique que es lo que quiero
            // que son los nombres de las personas que beben gaseosa
        }
    }
}
