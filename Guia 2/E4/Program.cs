using System;
using System.Collections.Generic;
namespace E4
{
    class Program
    {
        static void Imprimir(Peliteca peliteca)
        {
            Console.Clear();
            Console.WriteLine("\nNombre\t\tGenero\t\tAnio\t\tDirector");
            foreach (Pelicula peli in peliteca.busqueda)
            {
                Console.WriteLine(peli.nombre+"\t"+peli.genero+"\t\t"+peli.anio+"\t\t"+peli.director);
            }
            peliteca.busqueda.Clear();
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            int selec=1;
            string ingreso1;
            int ingreso;
            Peliteca rapipel = new Peliteca();
            while (selec!=0)
            {
                Console.WriteLine("1 - Buscar por genero\n2 - Buscar por nombre");
                Console.WriteLine("3 - Buscar por año\n4 - Buscar por director");
                Console.WriteLine("5 - Cantidad total de peliculas\n6 - Cantidad de peliculas en un genero");
                Console.WriteLine("0 - Salir");
                Console.Write("\nIngrese una seleccion: ");
                selec=Int32.Parse(Console.ReadLine());

                switch (selec)
                {
                    case 1:
                        Console.Write("Ingrese un genero: ");
                        ingreso1=Console.ReadLine();
                        rapipel.PorGenero(ingreso1);
                        Imprimir(rapipel);
                        break;
                    case 2:
                        Console.Write("Ingrese el nombre de una pelicula: ");
                        ingreso1=Console.ReadLine();
                        rapipel.PorNombre(ingreso1);
                        Imprimir(rapipel);
                        break;
                    case 3:
                        Console.Write("Ingrese un anio: ");
                        ingreso=Int32.Parse(Console.ReadLine());
                        rapipel.PorAnio(ingreso);
                        Imprimir(rapipel);
                        break;
                    case 4:
                        Console.Write("Ingrese un director: ");
                        ingreso1=Console.ReadLine();
                        rapipel.PorDirector(ingreso1);
                        Imprimir(rapipel);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("La cantidad total de peliculas es de "+rapipel.CantidadPeliculas());
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Write("Ingrese un genero: ");
                        ingreso1=Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("La cantidad de peliculas del genero ingresado es de "+rapipel.CantidadGenero(ingreso1));
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
