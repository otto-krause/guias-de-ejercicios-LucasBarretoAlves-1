using System;
using System.Linq;
using System.Collections.Generic;
namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona juan = new Persona();
            int cuenta;
            List<string> ultconocimientos;
            List<string> primconocimientos;
            int conocionmientos;

            cuenta = juan.Conocimientos.Count();
            ultconocimientos = juan.Conocimientos.GetRange(cuenta-5, cuenta-1);
            primconocimientos = juan.Conocimientos.GetRange(0,4);
            primconocimientos=primconocimientos.OrderBy(j => j).ToList();
            conocionmientos= juan.Conocimientos.Where(conocimiento => conocimiento.Contains("ción")).ToList().Count();

            Console.WriteLine("\nUltimos cinco conocimientos: ");
            ultconocimientos.ForEach(conocimiento => Console.WriteLine(conocimiento));
            Console.WriteLine("\nPrimeros cuatro conocimientos, alfabéticamente: ");
            primconocimientos.ForEach(conocimiento => Console.WriteLine(conocimiento));
            Console.WriteLine("\nConocimientos que contienen *ción*: "+conocionmientos);


        }
    }
}
