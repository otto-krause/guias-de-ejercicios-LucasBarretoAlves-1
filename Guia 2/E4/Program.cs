using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            int selec;
            Peliteca rapipel = new Peliteca();
            while (selec!=0)
            {
                Console.WriteLine("1 - Buscar por genero\n2 - Buscar por nombre");
                Console.WriteLine("3 - Buscar por año\n4 - Buscar por director");
                Console.WriteLine("5 - Cantidad total de peliculas\n6 - Cantidad de peliculas en un genero");
                Console.WriteLine("0 - Salir");
                Console.Write("\nIngrese una seleccion: ");
                selec=Int32.Parse(Console.ReadLine());
            }
        }
    }
}
