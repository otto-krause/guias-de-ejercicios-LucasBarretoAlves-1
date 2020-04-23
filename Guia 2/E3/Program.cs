using System;
using System.Collections.Generic;
namespace E3
{
    class Program
    {
        static void Agregado(Album album, Figurita figurita)
        {
            bool estado;
            estado=album.AgregarFigurita(figurita);
            if (estado)
                Console.WriteLine("La figurita se agrego exitosamente\n");
            else
                Console.WriteLine("Fallo al agregar - figurita repetida\n");
        }
        static void Main(string[] args)
        {
            Album album = new Album();
            int selec=1;
            string nombre;
            string posicion;
            string pais;
            int numero;
            while (selec!=0)
            {
                Console.WriteLine("\n1 - Agregar Figurita\n2 - Cantidad de delanteros");
                Console.WriteLine("3 - Cantidad de mediocampistas\n4 - Consultar completado del album");
                Console.WriteLine("0 - Salir");
                Console.WriteLine("Ingrese una seleccion: ");
                selec=Int32.Parse(Console.ReadLine());

                switch (selec)
                {
                    case 1:
                        Console.Write("Ingrese nombre del jugador: ");
                        nombre=Console.ReadLine();
                        Console.Write("\nIngrese posicion del jugador: ");
                        posicion=Console.ReadLine();
                        Console.Write("\nIngrese pais del jugador: ");
                        pais=Console.ReadLine();
                        Console.Write("\nIngrese numero de figurita: ");
                        numero=Int32.Parse(Console.ReadLine());
                        Figurita figurita = new Figurita(nombre, posicion, pais, numero);
                        Agregado(album, figurita);
                        break;
                    case 2:
                        Console.WriteLine("La cantidad de delanteros es de " + album.CuantosDe("Delantero"));
                        break;
                    case 3:
                        Console.WriteLine("La cantidad de mediocampistas es de " + album.CuantosDe("Mediocampista"));
                        break;
                    case 4:
                        if (album.EstaCompleto())
                            Console.WriteLine("El album esta completo");
                        else
                            Console.WriteLine("El album esta incompleto");
                        break;
                }
            }
            
        }
       
        
    }
}
