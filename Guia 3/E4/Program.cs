using System;
using System.Collections.Generic;
namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro gatopiola = new Libro ("Gatopiola 40", "Nico");
            Libro milibro = new Libro ("MI LIBRO", "Dr. Oss");
            Libro wiive = new Libro ("Wiive", "Nintendo");

            Tragalibros Juan = new Tragalibros();

            Juan.Leer(gatopiola);
            Juan.Leer(gatopiola);
            Juan.Leer(milibro);
            Juan.Leer(wiive);
            Console.WriteLine("Juan tiene "+Juan.CalcularCI() +" de coeficiente intelectual. Bien por Juan.");
        }
    }
}
