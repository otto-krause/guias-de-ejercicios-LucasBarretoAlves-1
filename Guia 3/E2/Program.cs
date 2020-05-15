using System;
using System.Collections.Generic;
namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa constructora = new Empresa(3630000, 2000);
            Console.WriteLine(constructora.GastoTotal());
            Console.WriteLine(constructora.Presupuesto);
            if (constructora.GastoTotal()<=constructora.Presupuesto)
                Console.WriteLine("El presupuesto alcanza para llevar a cabo el proyecto");
            else
            {
                Console.WriteLine("El presupuesto no alcanza para llevar a cabo el proyecto");
            }
                
        }
    }
}
