using System;
using System.Collections.Generic;
namespace E4
{
    public class Program
    {
        static void Main (string[] args)
        {
            string especialidad;
            Clinica sanatoriofebril = new Clinica ();
            Console.Write ("Ingrese la especialidad deseada (ingrese *salir* para salir): ");
            especialidad = Console.ReadLine ();
            while (especialidad != "salir")
            {

                Medico medico = sanatoriofebril.buscarMedico (especialidad);
                if (medico != null)
                    Console.WriteLine ("Se encontro la/el medico/a: " + medico.Nombre);
                else
                    Console.WriteLine ("No se encontro ningun medico disponible");
                Console.Write ("Ingrese la especialidad deseada: ");
                especialidad = Console.ReadLine ();
            }

        }
    }
}