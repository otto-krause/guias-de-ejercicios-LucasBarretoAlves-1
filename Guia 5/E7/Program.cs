using System;
using System.Collections.Generic;
using System.Linq;
namespace E7
{
    class Program
    {
        static void Main (string[] args)
        {
            Red_Social caralibro = new Red_Social ();
            List<Foto> listaDeFotos = new List<Foto> ();
            List<string> lista = new List<string> ();
            int selec = 1;
            string ingreso;
            string ingreso1;
            while (selec != 0)
            {
                Console.WriteLine ("\n1- Fotos del año de una persona\n" +
                    "2- Fotos en las que se etiquetó a dos personas en específico\n" +
                    "3- Comprobar si hubo alguna publicación de más de 300 caracteres\n");
                Console.WriteLine ("\nIngrese una selección (0 para salir): ");
                selec = Int32.Parse (Console.ReadLine ());

                switch (selec)
                {
                    case 1:
                        Console.WriteLine ("\nIngrese el nombre de una persona: ");
                        ingreso = Console.ReadLine ();
                        Console.Clear();
                        Console.WriteLine ("\nFotos del año de " + ingreso + ": ");
                        listaDeFotos = caralibro.fotosUltimoAño (ingreso);
                        if (listaDeFotos != null)
                            listaDeFotos.ForEach (foto => Console.WriteLine ("Directorio de almacenamiento: " +
                                foto.DirectorioDeAlmacenamiento +
                                " | Fecha de creacion: " + foto.FechaDeCreacion));
                        else
                            Console.WriteLine ("No hay fotos del ultimo año de esta persona.");
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine ("\nIngrese el nombre de una persona: ");
                        ingreso = Console.ReadLine ();
                        Console.WriteLine ("Ingrese el nombre de la segunda persona: ");
                        ingreso1 = Console.ReadLine ();
                        Console.Clear();
                        Console.WriteLine ("\nFotos en la que se etiquetó a " + ingreso + " con " + ingreso1 + ": ");
                        listaDeFotos = caralibro.fotosEtiquetadas (ingreso, ingreso1);
                        if (listaDeFotos != null)
                        {
                            listaDeFotos.ForEach (foto => Console.WriteLine ("Directorio de almacenamiento: " +
                                foto.DirectorioDeAlmacenamiento +
                                " | Fecha de creacion: " + foto.FechaDeCreacion));
                        }
                        else
                            Console.WriteLine ("No hay fotos con las personas mencionadas etiquetadas juntas");
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        if (caralibro.publicacionesDeMas300Caracteres () != null)
                        {
                            Console.WriteLine ("\nPublicaciones con más de 300 caracteres:");
                            caralibro.publicacionesDeMas300Caracteres ().ForEach (i => Console.WriteLine (i));
                        }    
                        else
                            Console.WriteLine ("No hay publicaciones mayores a 300 caracteres.");
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    default:
                        break;

                }
            }
        }
    }
}