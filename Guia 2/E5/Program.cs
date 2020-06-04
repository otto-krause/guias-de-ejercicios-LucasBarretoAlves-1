using System;
using System.Collections.Generic;
namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            Supermercado Eki = new Supermercado();
            Console.WriteLine("En el dia, el supermercado gano $"+Eki.Ventas());
        }
    }
}
