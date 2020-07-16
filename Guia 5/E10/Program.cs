using System;
using System.Collections.Generic;
using System.Linq;
namespace E10
{
    class Program
    {
        static void Main (string[] args)
        {
            Colegio ottokrause = new Colegio ();
            string opcion = ottokrause.fueExitoso () ? "fue exitoso ;)" : "no fue exitoso :(";
            Console.WriteLine ("El curso " + opcion);
        }
    }
}