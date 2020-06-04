using System;
using System.Collections.Generic;
namespace E6
{
    class Program
    {
        static void Imprimir (Steam biblio)
        {
            Console.Clear ();
            Console.WriteLine ("\nTitulo\t\tGenero\t\tCalificacion");
            foreach (Juego juego in biblio.Busqueda)
            {
                Console.WriteLine (juego.Titulo + "\t" + juego.Genero + "\t\t" + juego.CalificacionGeneral ());
            }
            biblio.Busqueda.Clear ();
            Console.WriteLine ("\nPresione una tecla para continuar...");
            Console.ReadKey ();
            Console.Clear ();
        }
        static void Main (string[] args)
        {
            int selec = 1;
            string ingreso;
            Steam biblioteca = new Steam ();
            while (selec != 0)
            {
                Console.WriteLine ("1 - Buscar por genero\n2 - Buscar por Calificacion");
                Console.WriteLine ("0 - Salir");
                Console.Write ("\nIngrese una seleccion: ");
                selec = Int32.Parse (Console.ReadLine ());

                switch (selec)
                {
                    case 1:
                        Console.Write ("Ingrese un genero: ");
                        ingreso = Console.ReadLine ();
                        biblioteca.PorGenero (ingreso);
                        Imprimir (biblioteca);
                        break;
                    case 2:
                        Console.Write ("Ingrese una clasificacion (Alta, Media, Baja): ");
                        ingreso = Console.ReadLine ();
                        biblioteca.PorCalificacion (ingreso);
                        Imprimir (biblioteca);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}