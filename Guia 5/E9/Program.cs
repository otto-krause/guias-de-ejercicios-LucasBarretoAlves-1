using System;
using System.Linq;
using System.Collections.Generic;
namespace E9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            int ingreso=1;
            while (ingreso!=0)
            {
                Console.WriteLine("Ingrese un numero (0 para finalizar): ");
                ingreso=Int32.Parse(Console.ReadLine());
                if (ingreso!=0)
                    numeros.Add(ingreso);
            }

            Console.WriteLine("Numeros de la lista: ");
            numeros.ForEach(num => Console.WriteLine(num));

            Console.WriteLine("La cantidad de numeros impares ingresados fue de "
            +numeros.Where(num => num%2!=0).ToList().Count());

            Console.WriteLine("El primer numero par ingresado fue "
            +numeros.Where(num => num%2==0).ToList().First());

            Console.WriteLine("Numeros mayores a 50 de la lista: ");
            numeros.Where(num => num>50).ToList().ForEach(num => Console.WriteLine(num));

            Console.WriteLine("Cantidad de numeros mayores a 50 en la lista: "
            +numeros.Where(num => num>50).ToList().Count());


        }
    }

        
}
