using System;
using System.Collections.Generic;
namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingreso=1;
            int primer=0;
            int ultimo=0;
            int i=0;
            int mayores=0;
            List<int> numeros = new List<int>();
            while (ingreso!=0)
            {
                Console.Write("Ingrese un numero: ");
                ingreso=Int32.Parse(Console.ReadLine());
                if (ingreso!=0)
                {
                    numeros.Add(ingreso);
                    ultimo=ingreso;
                }     
                if (i==0)
                    primer=ingreso;
                if (ingreso>50)
                    mayores++;
                i++;
                
            }
            Console.WriteLine("Los numeros de la lista son:");
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("\nLa cantidad de elementos ingresados fue de " + numeros.Count);
            Console.WriteLine("El primer numero fue " + primer);
            Console.WriteLine("El ultimo numero fue " + ultimo);
            Console.WriteLine("La cantidad de numeros mayores a 50 fue de " + mayores); 
        }
    }
}
