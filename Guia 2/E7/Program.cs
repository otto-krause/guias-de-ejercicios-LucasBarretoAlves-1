using System;
using System.Collections.Generic;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            Argentina elmasgrande = new Argentina();
            string estado;
            if (elmasgrande.PrecioGlobal()<500)
                estado="baja";
            else
            {
                if (elmasgrande.PrecioGlobal()<1000)
                    estado="super";
                else
                    estado="hyper";
            }
            Console.Write("Estado de inflacion: "+estado);

            if (estado=="hyper" && elmasgrande.UnProductor())
                Console.WriteLine("\nLa Argentina esta en default");


        }
    }
}
