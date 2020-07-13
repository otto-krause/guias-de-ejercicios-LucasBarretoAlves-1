using System;
using System.Linq;
using System.Collections.Generic;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            int perez;
            Persona raul = new Persona(19, "Raúl", "López");
            Persona carla = new Persona(22, "Carla", "Pérez");
            Persona juan = new Persona(15, "Juan", "Gaona");
            personas.Add(raul);
            personas.Add(carla);
            personas.Add(juan);

            List<Persona> mayoresDeEdad = personas.Where(persona => persona.Edad >= 18).ToList();
            List<Persona> juanes = personas.Where(persona => persona.Nombre == "Juan").ToList();
            perez = personas.Count(persona => persona.Apellido == "Pérez");

            Console.WriteLine("\nMayores de edad: ");
            mayoresDeEdad.ForEach(Persona => Console.WriteLine(Persona.Nombre +" "+ Persona.Apellido +", "+ Persona.Edad));
            Console.WriteLine("\nPersonas llamadas Juan: ");
            juanes.ForEach(Persona => Console.WriteLine(Persona.Nombre +" "+ Persona.Apellido +", "+ Persona.Edad));

            Console.WriteLine("\nLa cantidad de personas con el apellido Pérez es de " + perez);


        }
    }
}
