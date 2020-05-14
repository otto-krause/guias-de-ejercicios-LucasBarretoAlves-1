using System;
using System.Collections.Generic;
namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa constructora= new Empresa(0, 2000);
            if (constructora.GastoTotal()<constructora.Presupuesto)
                Console.WriteLine("El presupuesto alcanza para llevar a cabo el proyecto");
            else
            {
                Console.WriteLine("El presupuesto no alcanza para llevar a cabo el proyecto");
            }
                
        }
    }
}
