using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int num1;
            int producto=0;
            int cociente=0;
            int resto=0;
            Console.WriteLine("Ingrese un numero (1 de 2): ");
            num=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero (2 de 2): ");
            num1=Int32.Parse(Console.ReadLine());

            for (int i = 0; i < num1; i++)
            {
                producto+=num;
            }
            if ( num > 0 && num1 > 0 )
            {
                cociente = 0;
                resto = num;

                while ( resto >= num1 )
                {
                    resto -= num1;
                    cociente++;
                }
            }
            else
                Console.WriteLine("Error - uno de los numeros es 0");
            
            Console.WriteLine("El producto entre los numeros es "+ producto);
            Console.WriteLine("El cociente de la division entre los numeros es "+ cociente);
            Console.WriteLine("El resto de la division es de "+resto);
            

        }
    }
}
