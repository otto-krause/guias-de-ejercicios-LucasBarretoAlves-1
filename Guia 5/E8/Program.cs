using System;
using System.Collections.Generic;
using System.Linq;
namespace E8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>{7,4,6,2,8,10,3,1,7,6,4,3};
            Matematicas2 matematica = new Matematicas2();
            Console.WriteLine("De esta lista: ");
            Console.WriteLine("\nNumeros primos de la lista: ");
            matematica.Primos(numeros).ForEach(numero => Console.WriteLine(numero));
            
            Console.WriteLine("\nNumeros pares de la lista: ");
            matematica.Pares(numeros).ForEach(numero => Console.WriteLine(numero));
            
            Console.WriteLine("\nTodos los numeros de la lista (sin repetir): ");
            matematica.Aplanar(numeros).ForEach(numero => Console.WriteLine(numero));
            
            Console.WriteLine("\nLa suma de todos los numeros es "+ matematica.Suma(numeros));

            Console.WriteLine("La suma de los numeros primos es "+ matematica.SumaDePrimos(numeros));
            
            Console.WriteLine("El numero más grande es "+ matematica.Maximo(numeros));

            Console.WriteLine("El numero más chico es "+ matematica.Minimo(numeros));
            
        }
    }
}